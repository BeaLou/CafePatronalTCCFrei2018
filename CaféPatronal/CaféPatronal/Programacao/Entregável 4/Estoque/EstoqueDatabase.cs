using CaféPatronal.Programacao.ConnectionDB;
using mecanica.DB.Programação.Estoque;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_roupas.DB.Estoque
{
    class EstoqueDatabase
    {
        public int Salvar(EstoqueDTO dto)
        {
            string script =
                @"INSERT INTO tb_estoque
                (id_compra, ds_quantidade)
                VALUES
                (@id_compra, @ds_quantidade)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", dto.id_compra));
            parms.Add(new MySqlParameter("ds_quantidade", dto.Quantidade));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Alterar(EstoqueDTO dto)
        {
            string script = @"UPDATE tb_estoque SET 
                        ds_quantidade = @ds_quantidade 
                        WHERE id_compra = @id_compra";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_quantidade", dto.Quantidade));
            parms.Add(new MySqlParameter("id_compra", dto.id_compra));
            

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_estoque WHERE id_compra = @id_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<vwEstoque> Consultar(string nome)
        {
            string script = @"Select nm_compra, nm_nome, ds_quantidade, tb_estoque.id_compra, dt_compra FROM tb_estoque 
                                JOIN tb_compra 			p
                                ON p.id_compra = tb_estoque.id_compra
                                JOIN tb_fornecedor 			f
                                ON f.id_fornecedor = p.id_fornecedor where nm_compra like @nm_compra;";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_compra", nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<vwEstoque> lista = new List<vwEstoque>();
            while (reader.Read())
            {
                vwEstoque dto = new vwEstoque();
                dto.Id = reader.GetInt32("id_compra");
                dto.Compra = reader.GetString("nm_compra");
                dto.Quantidade = reader.GetInt32("ds_quantidade");
                dto.Fornecedor = reader.GetString("nm_nome");
                dto.Data = reader.GetDateTime("dt_compra");


                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }

        public List<EstoqueDTO> Listar()
        {
            string script = @"Select * FROM tb_estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EstoqueDTO> lista = new List<EstoqueDTO>();
            while (reader.Read())
            {
                EstoqueDTO dto = new EstoqueDTO();
                dto.Id = reader.GetInt32("id_estoque");
                dto.id_compra = reader.GetInt32("id_compra");
                dto.Quantidade = reader.GetInt32("ds_quantidade");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
