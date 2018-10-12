using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_2.Compras
{
    class CompraItemDatabase
    {
        public int Salvar(CompraItemDTO compras)
        {
            string script =
                @"INSERT INTO tb_compra
                (
                id_compraitem,
                id_compra,   
                id_produto  
                )
                VALUES
                (
                @id_compraitem,
                @id_compra,   
                @id_produto
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compraitem", compras.id_compraitem));
            parms.Add(new MySqlParameter("id_compra", compras.id_compra));
            parms.Add(new MySqlParameter("id_produto", compras.id_produto));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_compraitem WHERE id_compraitem = @id_compraitem";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compraitem", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<CompraItemDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_compraitem";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CompraItemDTO> compras = new List<CompraItemDTO>();
            while (reader.Read())
            {

                CompraItemDTO novacompra = new CompraItemDTO();
                novacompra.id_compraitem = reader.GetInt32("id_compraitem");
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_produto = reader.GetInt32("id_produto");

                compras.Add(novacompra);

            }
            return compras;
        }

        public List<CompraItemDTO> Consultar(string produto)
        {

            string script =
                @"SELECT * FROM tb_compraitem
                  WHERE id_produto like @id_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", "%" + produto + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<CompraItemDTO> compras = new List<CompraItemDTO>();
            while (reader.Read())
            {

                CompraItemDTO novacompra = new CompraItemDTO();
                novacompra.id_compraitem = reader.GetInt32("id_compraitem");
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_produto = reader.GetInt32("id_produto");

                compras.Add(novacompra);

            }
            return compras;
        }

        public void Alterar(CompraItemDTO compra)
        {
            string script =
            @"UPDATE tb_compraitem
                 SET 
                  id_compraitem = @id_compraitem,
                  id_compra = @id_compra,
                  id_produto = @id_produto,
                  WHERE id_compraitem = @id_compraitem";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compraitem", compra.id_compraitem));
            parms.Add(new MySqlParameter("id_compra", compra.id_compra));
            parms.Add(new MySqlParameter("id_produto", compra.id_produto));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
