using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.ConnectionDB
{
    class Connection
    {
        
            public MySqlConnection Create()
            {
                string connectionString = "server=104.214.59.125;database=DBcafe;uid=nsf;password=nsf@2018;sslmode=none";

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                return connection;
            }

        
    }
}
