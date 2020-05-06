using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Cliente
{
    public class ClienteDatabase
    {
        public int Salvar(ClienteDTO cliente)
        {
            string script =
                @"INSERT INTO tb_cliente
                (
                    id_cliente,
                    nm_nome,
                    nm_sobrenome,
                    dt_datanascimento,
                    ds_cpf,
                    ds_email
                )
                VALUES
                (
                    @id_cliente,
                    @nm_nome,
                    @nm_sobrenome,
                    @dt_datanascimento,
                    @ds_cpf,
                    @ds_email  
                )";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_cliente", cliente.id_cliente));
            parms.Add(new SqlParameter("nm_nome", cliente.nm_nome));
            parms.Add(new SqlParameter("nm_sobrenome", cliente.nm_sobrenome));
            parms.Add(new SqlParameter("dt_datanascimento", cliente.dt_datanascimento));
            parms.Add(new SqlParameter("ds_cpf", cliente.ds_cpf));
            parms.Add(new SqlParameter("ds_email", cliente.ds_email));
            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(ClienteDTO cliente)
        {

            string script =
            @"UPDATE tb_cliente
                 SET
                  nm_nome = @nm_nome,
                  nm_sobrenome = @nm_sobrenome,
                  dt_datanascimento = @dt_datanascimento,
                  ds_cpf = @ds_cpf,
                  ds_email = @ds_email
                  WHERE id_cliente = @id_cliente";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_cliente", cliente.id_cliente));
            parms.Add(new SqlParameter("nm_nome", cliente.nm_nome));
            parms.Add(new SqlParameter("nm_sobrenome", cliente.nm_sobrenome));
            parms.Add(new SqlParameter("dt_datanascimento", cliente.dt_datanascimento));
            parms.Add(new SqlParameter("ds_cpf", cliente.ds_cpf));
            parms.Add(new SqlParameter("ds_email", cliente.ds_email));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_cliente WHERE id_cliente = @id_cliente";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_cliente", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ClienteDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_cliente";
            List<SqlParameter> parms = new List<SqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClienteDTO> clientes = new List<ClienteDTO>();
            while (reader.Read())
            {

                ClienteDTO novocliente = new ClienteDTO();
                novocliente.id_cliente = reader.GetInt32("id_cliente");
                novocliente.nm_nome = reader.GetString("nm_nome");
                novocliente.nm_sobrenome = reader.GetString("nm_sobrenome");
                novocliente.dt_datanascimento = reader.GetDateTime("dt_datanascimento");
                novocliente.ds_cpf = reader.GetString("ds_cpf");
                novocliente.ds_email = reader.GetString("ds_email");

                clientes.Add(novocliente);

            }
            reader.Close();
            return clientes;
        }

        public List<ClienteDTO> Consultar(string cliente)
        {

            string script =
                @"SELECT * FROM tb_cliente
                  WHERE nm_nome like @nm_nome";
            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("nm_nome", "%" + cliente + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ClienteDTO> clientes = new List<ClienteDTO>();
            while (reader.Read())
            {

                ClienteDTO novocliente = new ClienteDTO();
                novocliente.id_cliente = reader.GetInt32("id_cliente");
                novocliente.nm_nome = reader.GetString("nm_nome");
                novocliente.nm_sobrenome = reader.GetString("nm_sobrenome");
                novocliente.dt_datanascimento = reader.GetDateTime("dt_datanascimento");
                novocliente.ds_cpf = reader.GetString("ds_cpf");
                novocliente.ds_email = reader.GetString("ds_email");

                clientes.Add(novocliente);

            }
            reader.Close();
            return clientes;

        }

    }
}
