using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produtocompra", producompra.id_produtocompra));
            parms.Add(new MySqlParameter("nm_produtocompra", producompra.nm_produtocompra));
            parms.Add(new MySqlParameter("vl_valor", producompra.nm_produtocompra));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
    }
}
