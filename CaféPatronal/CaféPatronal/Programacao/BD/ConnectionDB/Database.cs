using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.ConnectionDB
{
   public class Database
    {
        public void ExecuteInsertScript(string script, List<SqlParameter> parameters)
        {
            Connection conn = new Connection();
            MySqlConnection connection = conn.Create();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = script;

            if (parameters != null)
            {
                foreach(SqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            command.ExecuteNonQuery();
            connection.Close();
        }

        public int ExecuteInsertScriptWithPk(string script, List<SqlParameter> parameters)
        {
            Connection conn = new Connection();
            MySqlConnection connection = conn.Create();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = script;

            if (parameters != null)
            {
                foreach (SqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            command.ExecuteNonQuery();
            connection.Close();

            int id = Convert.ToInt32(command.LastInsertedId);
            return id;
        }

        public MySql.Data.MySqlClient.MySqlDataReader ExecuteSelectScript(string script, List<SqlParameter> parameters)
        {
            Connection conn = new Connection();
            MySqlConnection connection = conn.Create();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = script;

            if (parameters != null)
            {
                foreach (SqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            MySqlDataReader reader =
                 command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;

        }

    }
}
