using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Dpto
{
 public   class DptoDatabase
    {
        public List<DptoDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_dpto";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<DptoDTO> lista = new List<DptoDTO>();

            while (reader.Read())
            {
                DptoDTO det = new DptoDTO();
                det.nm_nome = reader.GetString("nm_nome");
                lista.Add(det);
            }
            reader.Close();
            return lista;
        }
}
