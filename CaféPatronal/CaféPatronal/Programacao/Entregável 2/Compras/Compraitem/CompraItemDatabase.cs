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
    class CompraItemDatabase
    {
        public int Salvar(CompraItemDTO compras)
        {
            string script =
                @"INSERT INTO tb_compraitem
                (
                id_compraitem,
                id_compra,   
                id_produtocompra  
                )
                VALUES
                (
                @id_compraitem,
                @id_compra,   
                @id_produtocompra
                )";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_compraitem", compras.id_compraitem));
            parms.Add(new SqlParameter("id_compra", compras.id_compra));
            parms.Add(new SqlParameter("id_produtocompra", compras.id_produtocompra));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Remover(int id)
        {
            string script =
            @"DELETE FROM vw_consultar_item WHERE id_compra= @id_compra";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_compra", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<CompraItemDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_compraitem";
            List<SqlParameter> parms = new List<SqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CompraItemDTO> compras = new List<CompraItemDTO>();
            while (reader.Read())
            {

                CompraItemDTO novacompra = new CompraItemDTO();
                novacompra.id_compraitem = reader.GetInt32("id_compraitem");
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_produtocompra = reader.GetInt32("id_produtocompra");

                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }

        public List<CompraItemDTO> Consultar(string produto)
        {

            string script =
                @"SELECT * FROM tb_compraitem
                  WHERE id_produto like @id_produto";
            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_produto", "%" + produto + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<CompraItemDTO> compras = new List<CompraItemDTO>();
            while (reader.Read())
            {

                CompraItemDTO novacompra = new CompraItemDTO();
                novacompra.id_compraitem = reader.GetInt32("id_compraitem");
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_produtocompra = reader.GetInt32("id_produtocompra");

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
                  id_produtocompra = @id_produtocompra,
                  WHERE id_compraitem = @id_compraitem";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_compraitem", compra.id_compraitem));
            parms.Add(new SqlParameter("id_compra", compra.id_compra));
            parms.Add(new SqlParameter("id_produtocompra", compra.id_produtocompra));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<VwConsultarItem> ConsultarView(string produto)
        {

            string script =
                @"SELECT * FROM vw_consultar_item
                  WHERE nm_produtocompra like @nm_produtocompra";
            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("nm_produtocompra", "%" + produto + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<VwConsultarItem> compras = new List<VwConsultarItem>();
            while (reader.Read())
            {

                VwConsultarItem novacompra = new VwConsultarItem();
                novacompra.nm_produtocompra = reader.GetString("nm_produtocompra");
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.qtd_itens = reader.GetInt32("qtd_itens");
                novacompra.vl_total = reader.GetDecimal("vl_total");
                novacompra.id_produtocompra = reader.GetInt32("id_produtocompra");
                novacompra.dt_compra = reader.GetDateTime("dt_compra");


                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }
        public List<VwConsultarItem> ConsultarViewPorId(int id)
        {

            string script =
                @"SELECT * FROM vw_consultar_item
                  WHERE id_compra = @id_compra";
            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_compra", id));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<VwConsultarItem> compras = new List<VwConsultarItem>();
            while (reader.Read())
            {

                VwConsultarItem novacompra = new VwConsultarItem();
                novacompra.nm_produtocompra = reader.GetString("nm_produtocompra");
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.qtd_itens = reader.GetInt32("qtd_itens");
                novacompra.vl_total = reader.GetDecimal("vl_total");
                novacompra.id_produtocompra = reader.GetInt32("id_produtocompra");
                novacompra.dt_compra = reader.GetDateTime("dt_compra");


                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }
    }
}
