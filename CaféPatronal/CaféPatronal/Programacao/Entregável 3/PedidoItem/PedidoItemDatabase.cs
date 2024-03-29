﻿using CaféPatronal.Programacao.ConnectionDB;
using CaféPatronal.Programacao.Entregável_3.PedidoItem;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.PedidoItem
{
    public class PedidoItemDatabase
    {



        public int Salvar(PedidoItemDTO pedidoitem)
        {
            string script =
                @"INSERT INTO tb_pedidoitem
                (
                id_pedidoitem,
                id_produto,
                id_pedido
                )
                VALUES
                (
                @id_pedidoitem,
                @id_produto,
                @id_pedido
                )";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_pedidoitem", pedidoitem.id_pedidoitem));
            parms.Add(new SqlParameter("id_produto", pedidoitem.id_produto));
            parms.Add(new SqlParameter("id_pedido", pedidoitem.id_pedido));
           

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(PedidoItemDTO pedidoitem)
        {
            string script =
            @"UPDATE tb_pedidoitem
                 SET
                id_produto  = @id_produto,
                id_pedido  = @id_pedido
                  WHERE id_pedidoitem = @id_pedidoitem,";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_pedidoitem", pedidoitem.id_pedidoitem));
            parms.Add(new SqlParameter("id_produto", pedidoitem.id_produto));
            parms.Add(new SqlParameter("id_pedido", pedidoitem.id_pedido));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_pedidoitem WHERE id_pedido = @id_pedido";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_pedido", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<PedidoItemDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_pedido";
            List<SqlParameter> parms = new List<SqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoItemDTO> pedidositem = new List<PedidoItemDTO>();
            while (reader.Read())
            {

                PedidoItemDTO novopedidoitem = new PedidoItemDTO();
                novopedidoitem.id_pedidoitem = reader.GetInt32("id_pedidoitem");
                novopedidoitem.id_produto = reader.GetInt32("id_produto");
                novopedidoitem.id_pedido = reader.GetInt32("id_pedido");

                pedidositem.Add(novopedidoitem);

            }
            reader.Close();
            return pedidositem;
        }

        public List<PedidoItemDTO> Consultar(string pedidoitem)
        {

            string script =
                @"SELECT * FROM tb_pedidoitem
                  WHERE id_pedidoitem like @id_pedidoitem";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_pedidoitem", "%" + pedidoitem + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoItemDTO> pedidositem = new List<PedidoItemDTO>();
            while (reader.Read())
            {

                PedidoItemDTO novopedidoitem = new PedidoItemDTO();
                novopedidoitem.id_pedidoitem = reader.GetInt32("id_pedidoitem");
                novopedidoitem.id_produto = reader.GetInt32("id_produto");
                novopedidoitem.id_pedido = reader.GetInt32("id_pedido");

                pedidositem.Add(novopedidoitem);

            }
            reader.Close();
            return pedidositem;

        }
          public List<VwConsultarItem> ConsultarItem (int comandaid)
        {
            string script = @"SELECT * FROM vw_consultar_item_pedido
                               WHERE id_pedido like @id_pedido";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_pedido", "%" + comandaid + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VwConsultarItem> consultarite = new List<VwConsultarItem>();
            while (reader.Read())
            {
                VwConsultarItem novoconsulta = new VwConsultarItem();
                novoconsulta.id_pedido = reader.GetInt32("id_pedido");
                novoconsulta.nm_nome = reader.GetString("nm_nome");
                novoconsulta.dt_venda = reader.GetDateTime("dt_venda");
                novoconsulta.ds_formapagamento = reader.GetString("ds_formapagamento");
                novoconsulta.qtd_itens = reader.GetInt32("qtd_itens");
                novoconsulta.vl_total = reader.GetDecimal("vl_total");

                consultarite.Add(novoconsulta);
            }
            reader.Close();
            return consultarite;
        }
        public List<VwConsultarItem> ListarItem()
        {
            string script = @"SELECT * FROM vw_consultar_item_pedido
                               ";

            List<SqlParameter> parms = new List<SqlParameter>();
          

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VwConsultarItem> consultarite = new List<VwConsultarItem>();
            while (reader.Read())
            {
                VwConsultarItem novoconsulta = new VwConsultarItem();
                novoconsulta.id_pedido = reader.GetInt32("id_pedido");
                novoconsulta.nm_nome = reader.GetString("nm_nome");
                novoconsulta.dt_venda = reader.GetDateTime("dt_venda");
                novoconsulta.ds_formapagamento = reader.GetString("ds_formapagamento");
                novoconsulta.qtd_itens = reader.GetInt32("qtd_itens");
                novoconsulta.vl_total = reader.GetDecimal("vl_total");

                consultarite.Add(novoconsulta);
            }
            reader.Close();
            return consultarite;
        }



    }
}
