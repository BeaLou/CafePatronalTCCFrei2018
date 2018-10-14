using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Pedido
{
    public class PedidoDatabase
    {

        public int Salvar(PedidoDTO pedido)
        {
            string script =
                @"INSERT INTO tb_pedido
                (
                id_pedido,
                id_cliente,
                dt_venda,
                ds_formapagamento
                )
                VALUES
                (
                @id_pedido,
                @id_cliente,
                @dt_venda,
                @ds_formapagamento
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", pedido.id_pedido));
            parms.Add(new MySqlParameter("id_cliente", pedido.id_cliente));
            parms.Add(new MySqlParameter("dt_venda", pedido.dt_venda));
            parms.Add(new MySqlParameter("ds_formapagamento", pedido.ds_formapagamento));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(PedidoDTO pedido)
        {
            string script =
            @"UPDATE tb_pedido
                 SET
                  id_cliente = @id_cliente,
                  dt_venda = @dt_venda,
                  ds_formapagamento = @ds_formapagamento  
                  WHERE id_pedido = @id_pedido,";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", pedido.id_pedido));
            parms.Add(new MySqlParameter("id_cliente", pedido.id_cliente));
            parms.Add(new MySqlParameter("dt_venda", pedido.dt_venda));
            parms.Add(new MySqlParameter("ds_formapagamento", pedido.ds_formapagamento));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_pedido WHERE id_pedido = @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<PedidoDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_pedido";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoDTO> pedidos = new List<PedidoDTO>();
            while (reader.Read())
            {

                PedidoDTO novopedido = new PedidoDTO();
                novopedido.id_pedido = reader.GetInt32("id_pedido");
                novopedido.id_cliente = reader.GetInt32("id_cliente");
                novopedido.dt_venda = reader.GetDateTime("dt_venda");
                novopedido.ds_formapagamento = reader.GetString("ds_formapagamento");


                pedidos.Add(novopedido);

            }
            reader.Close();
            return pedidos;
        }

        public List<PedidoDTO> Consultar(string pedido)
        {

            string script =
                @"SELECT * FROM tb_pedido
                  WHERE id_pedido like @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", "%" + pedido + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoDTO> pedidos = new List<PedidoDTO>();
            while (reader.Read())
            {

                PedidoDTO novopedido = new PedidoDTO();
                novopedido.id_pedido = reader.GetInt32("id_pedido");
                novopedido.id_cliente = reader.GetInt32("id_cliente");
                novopedido.dt_venda = reader.GetDateTime("dt_venda");
                novopedido.ds_formapagamento = reader.GetString("ds_formapagamento");

                pedidos.Add(novopedido);

            }
            reader.Close();
            return pedidos;

        }


    }
}
