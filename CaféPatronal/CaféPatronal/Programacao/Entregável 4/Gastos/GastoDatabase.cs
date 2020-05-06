using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_4.Gastos
{
    public class GastoDatabase
    {
        public int Salvar(GastoDTO dto)
        {
            string script = @"INSERT INTO tb_gasto
                (nm_gasto, ds_tipo, dt_pagamento, vl_gasto)
                VALUES
                (@nm_gasto, @ds_tipo, @dt_pagamento, @vl_gasto)";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("nm_gasto", dto.Gasto));
            parms.Add(new SqlParameter("ds_tipo", dto.Tipo));
            parms.Add(new SqlParameter("dt_pagamento", dto.Pagamento));
            parms.Add(new SqlParameter("vl_gasto", dto.Valor));

            Database db = new Database();

            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<GastoDTO> Consultar(string gasto)
        {
            string script = @"SELECT * FROM tb_gasto WHERE nm_gasto like @nm_gasto";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("nm_gasto", gasto + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<GastoDTO> lista = new List<GastoDTO>();

            while (reader.Read())
            {
                GastoDTO dto = new GastoDTO();

                dto.Id = reader.GetInt32("id_gasto");
                dto.Gasto = reader.GetString("nm_gasto");
                dto.Tipo = reader.GetString("ds_tipo");
                dto.Pagamento = reader.GetDateTime("dt_pagamento");
                dto.Valor = reader.GetDecimal("vl_gasto");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public List<GastoDTO> Listar()
        {
            string script = @"SELECT * FROM tb_gasto";

            List<SqlParameter> parms = new List<SqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<GastoDTO> lista = new List<GastoDTO>();

            while (reader.Read())
            {
                GastoDTO dto = new GastoDTO();

                dto.Id = reader.GetInt32("id_gasto");
                dto.Gasto = reader.GetString("nm_gasto");
                dto.Tipo = reader.GetString("ds_tipo");
                dto.Pagamento = reader.GetDateTime("dt_pagamento");
                dto.Valor = reader.GetDecimal("vl_gasto");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public void Remover(int id)
        {
            string script = "DELETE FROM tb_gasto WHERE id_gasto = id_gasto";
            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_gasto", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Alterar(GastoDTO dto)
        {
            string script = @"UPDATE tb_gasto SET 
                        nm_gasto = @nm_gasto, 
                        ds_tipo = @ds_tipo, 
                        dt_pagamento = @dt_pagamento, 
                        vl_gasto = @vl_gasto
                        WHERE id_gasto = @id_gasto";


            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_gasto", dto.Id));
            parms.Add(new SqlParameter("nm_gasto", dto.Gasto));
            parms.Add(new SqlParameter("ds_tipo", dto.Tipo));
            parms.Add(new SqlParameter("dt_pagamento", dto.Pagamento));
            parms.Add(new SqlParameter("vl_gasto", dto.Valor));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


    }
}
