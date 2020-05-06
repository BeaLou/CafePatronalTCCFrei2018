using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.FluxoCaixa
{
    public class FluxoCaixaDatabase
    {
        public List<FluxoCaixaVw> Consultar(DateTime Inicio, DateTime Fim)
        {
            string script = @"select * from vw_consultar_fluxodecaixa
            WHERE dt_referencia >= @dt_inicio
                AND dt_referencia <= @dt_fim;";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("dt_inicio", Inicio));
            parms.Add(new SqlParameter("dt_fim", Fim));


            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FluxoCaixaVw> lista = new List<FluxoCaixaVw>();

            while (reader.Read())
            {
                FluxoCaixaVw dto = new FluxoCaixaVw();

                dto.Data = reader.GetDateTime("dt_referencia");
                dto.Despesas = reader.GetDecimal("vl_total_despesas");
                dto.Ganhos = reader.GetDecimal("vl_total_ganhos");
                dto.Lucro = reader.GetDecimal("vl_saldo");

                lista.Add(dto);
            }
            reader.Close();

            return lista;

        }
        public List<FluxoCaixaVw> Listar()
        {
            string script = @"select * from vw_consultar_fluxodecaixa";


            List<SqlParameter> parms = new List<SqlParameter>();
            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FluxoCaixaVw> lista = new List<FluxoCaixaVw>();

            while (reader.Read())
            {
                FluxoCaixaVw dto = new FluxoCaixaVw();

                dto.Data = reader.GetDateTime("dt_referencia");
                dto.Despesas = reader.GetDecimal("vl_total_despesas");
                dto.Ganhos = reader.GetDecimal("vl_total_ganhos");
                dto.Lucro = reader.GetDecimal("vl_saldo");

                lista.Add(dto);
            }
            reader.Close();

            return lista;

        }
    }
}
