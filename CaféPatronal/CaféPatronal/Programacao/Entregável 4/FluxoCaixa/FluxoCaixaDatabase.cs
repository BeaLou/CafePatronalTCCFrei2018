using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_inicio", Inicio));
            parms.Add(new MySqlParameter("dt_fim", Fim));


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


            List<MySqlParameter> parms = new List<MySqlParameter>();
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
