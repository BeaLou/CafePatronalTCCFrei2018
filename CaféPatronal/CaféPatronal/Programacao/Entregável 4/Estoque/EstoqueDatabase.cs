using CaféPatronal.Programacao.ConnectionDB;
using CaféPatronal.Programacao.Entregável_4.Estoque;
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
                (id_produtocompra, ds_quantidade)
                VALUES
                (@id_produtocompra, @ds_quantidade)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produtocompra", dto.id_produtocompra));
            parms.Add(new MySqlParameter("ds_quantidade", dto.ds_quantidade));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }



        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_estoque WHERE id_produtocompra = @id_produtocompra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<EstoqueDTO> Consultar(string estoq)
        {

            string script =
                @"SELECT * FROM tb_estoque
                  WHERE id_estoque like @id_estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estoque", "%" + estoq + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<EstoqueDTO> fornecedores = new List<EstoqueDTO>();
            while (reader.Read())
            {

                EstoqueDTO novoestoq = new EstoqueDTO();

                novoestoq.id_estoque = reader.GetInt32("id_estoque");
                novoestoq.id_produtocompra = reader.GetInt32("id_produtocompra");
                novoestoq.ds_quantidade = reader.GetDecimal("ds_quantidade");

                fornecedores.Add(novoestoq);

            }
            reader.Close();
            return fornecedores;
        }

        public List<EstoqueDTO> Listar()
        {

            string script =
                @"SELECT * FROM tb_estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<EstoqueDTO> fornecedores = new List<EstoqueDTO>();
            while (reader.Read())
            {

                EstoqueDTO novoestoq = new EstoqueDTO();

                novoestoq.id_estoque = reader.GetInt32("id_estoque");
                novoestoq.id_produtocompra = reader.GetInt32("id_produtocompra");
                novoestoq.ds_quantidade = reader.GetDecimal("ds_quantidade");

                fornecedores.Add(novoestoq);

            }
            reader.Close();
            return fornecedores;
        }

        public void Alterar(EstoqueDTO dto)
        {
            string script =
            @"UPDATE tb_estoque
                 SET 
                  ds_quantidade = @ds_quantidade
                  
                  WHERE id_produtocompra = @id_produtocompra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produtocompra", dto.id_produtocompra));
            parms.Add(new MySqlParameter("ds_quantidade", dto.ds_quantidade));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<vwconsultarestoque> ConsultarEstoque(string produtoestoque)
        {

            string script =
                @"SELECT * FROM vw_consultar_estoque
                  WHERE nm_produtocompra like @nm_produtocompra";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produtocompra", "%" + produtoestoque + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<vwconsultarestoque> fornecedores = new List<vwconsultarestoque>();
            while (reader.Read())
            {

                vwconsultarestoque novoestoq = new vwconsultarestoque();
                novoestoq.nm_produtocompra = reader.GetString("nm_produtocompra");
                novoestoq.ds_quantidade = reader.GetDecimal("ds_quantidade");

                fornecedores.Add(novoestoq);

            }
            reader.Close();
            return fornecedores;
        }
        public vwconsultarestoque ConsultarEstoqueView(string produtoestoque)
        {
            string script =
                @"SELECT * FROM vw_consultar_estoque
                  WHERE nm_produtocompra = @nm_produtocompra";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produtocompra", produtoestoque));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            vwconsultarestoque fornecedores = new vwconsultarestoque();
            while (reader.Read())
            {
                fornecedores.nm_produtocompra = reader.GetString("nm_produtocompra");
                fornecedores.ds_quantidade = reader.GetDecimal("ds_quantidade");
            }
            reader.Close();
            return fornecedores;
        }

    }
}
