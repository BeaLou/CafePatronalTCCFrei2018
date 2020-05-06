using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                dt_compra
                
                )
                VALUES
                (
                @id_compra,
                @id_fornecedor,   
                @dt_compra
                
                )";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_compra", compras.id_compra));
            parms.Add(new SqlParameter("id_fornecedor", compras.id_fornecedor));
            parms.Add(new SqlParameter("dt_compra", compras.dt_compra));
           

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_compra WHERE id_compra = @id_compra";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_compra", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ComprasDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_compra";
            List<SqlParameter> parms = new List<SqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ComprasDTO> compras = new List<ComprasDTO>();
            while (reader.Read())
            {

                ComprasDTO novacompra = new ComprasDTO();
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_fornecedor = reader.GetInt32("id_fornecedor");
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
                  WHERE dt_compra like @dt_compra";
            List<SqlParameter> parms = new List<SqlParameter>();
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ComprasDTO> compras = new List<ComprasDTO>();
            while (reader.Read())
            {

                ComprasDTO novacompra = new ComprasDTO();
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_fornecedor = reader.GetInt32("id_fornecedor");
                novacompra.dt_compra = reader.GetDateTime("dt_compra");
                
                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }
    }
}
