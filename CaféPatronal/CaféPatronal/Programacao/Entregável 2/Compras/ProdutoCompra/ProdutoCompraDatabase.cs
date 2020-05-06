using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_2.Compras.ProdutoCompra
{
    class ProdutoCompraDatabase
    {
        public int Salvar(ProdutoCompraDTO producompra)
        {
            string script =
                @"INSERT INTO tb_produtocompra
                (
                id_produtocompra,
                nm_produtocompra,
                vl_valor
                )
                VALUES
                (
                @id_produtocompra,
                @nm_produtocompra,
                @vl_valor
                )";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_produtocompra", producompra.id_produtocompra));
            parms.Add(new SqlParameter("nm_produtocompra", producompra.nm_produtocompra));
            parms.Add(new SqlParameter("vl_valor", producompra.vl_valor));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public List<ProdutoCompraDTO> Consultar(string produtocompra)
        {

            string script =
                @"SELECT * FROM tb_produtocompra
                  WHERE nm_produtocompra like @nm_produtocompra";
            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("nm_produtocompra", produtocompra + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoCompraDTO> compras = new List<ProdutoCompraDTO>();
            while (reader.Read())
            {

                ProdutoCompraDTO novacompra = new ProdutoCompraDTO();
                novacompra.id_produtocompra = reader.GetInt32("id_produtocompra");
                novacompra.nm_produtocompra = reader.GetString("nm_produtocompra");
                novacompra.vl_valor = reader.GetDecimal("vl_valor");

                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }
        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_produtocompra WHERE id_produtocompra= @id_produtocompra";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_produtocompra", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
