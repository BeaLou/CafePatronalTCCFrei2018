using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_2.Compras
{
   public class ComprasDatabase
    {
        public int Salvar(ComprasDTO compras)
        {
            string script =
                @"INSERT INTO tb_compra
                (
                id_compra,
                id_fornecedor,   
                nm_compra,
                qtd_unidade,     
                vl_compra,
                dt_compra
                )
                VALUES
                (
                @id_compra,
                @id_fornecedor,   
                @nm_compra,
                @qtd_unidade,     
                @vl_compra,
                @dt_compra
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", compras.id_compra));
            parms.Add(new MySqlParameter("id_fornecedor", compras.id_fornecedor));
            parms.Add(new MySqlParameter("nm_compra", compras.nm_compra));
            parms.Add(new MySqlParameter("qtd_unidade", compras.qtd_unidade));
            parms.Add(new MySqlParameter("vl_compra", compras.vl_compra));
            parms.Add(new MySqlParameter("dt_compra", compras.dt_compra));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_compra WHERE id_compra = @id_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ComprasDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_compra";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ComprasDTO> compras = new List<ComprasDTO>();
            while (reader.Read())
            {

                ComprasDTO novacompra = new ComprasDTO();
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_fornecedor = reader.GetInt32("id_fornecedor");
                novacompra.nm_compra = reader.GetString("nm_compra");
                novacompra.qtd_unidade = reader.GetString("qtd_unidade");
                novacompra.vl_compra = reader.GetDecimal("vl_compra");
                novacompra.dt_compra = reader.GetDateTime("dt_compra");

                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }

        public List<ComprasDTO> Consultar(string compra)
        {

            string script =
                @"SELECT * FROM tb_compra
                  WHERE nm_compra like @nm_compra";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_compra", "%" + compra + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ComprasDTO> compras = new List<ComprasDTO>();
            while (reader.Read())
            {

                ComprasDTO novacompra = new ComprasDTO();
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_fornecedor = reader.GetInt32("id_fornecedor");
                novacompra.nm_compra = reader.GetString("nm_compra");
                novacompra.qtd_unidade = reader.GetString("qtd_unidade");
                novacompra.vl_compra = reader.GetDecimal("vl_compra");
                novacompra.dt_compra = reader.GetDateTime("dt_compra");

                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }
    }
}
