using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.ControlePagamento
{
    public class CpDatabase
    {
        public int Salvar(CpDTO folha)
        {
            string script =
                @"INSERT INTO tb_controlefolhapagamento
                (
                id_controlefolhapagamento,
                dt_dia,   
                hr_entrada,
                hr_saida,
                hr_almoco,     
                hr_retornoalmoco,
                hr_horaextra,
                hr_saidahoraextra
                )
                VALUES
                (
                @id_controlefolhapagamento,
                @dt_dia,   
                @hr_entrada,
                @hr_saida,
                @hr_almoco,     
                @hr_retornoalmoco,
                @hr_horaextra,
                @hr_saidahoraextra
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_controlefolhapagamento", folha.id_controlefolhapagamento));
            parms.Add(new MySqlParameter("dt_dia", folha.dia));
            parms.Add(new MySqlParameter("hr_entrada", folha.horaentrada));
            parms.Add(new MySqlParameter("hr_saida", folha.horasaida));
            parms.Add(new MySqlParameter("hr_almoco", folha.horaalmoco));
            parms.Add(new MySqlParameter("hr_retornoalmoco", folha.horaretornoalmoco));
            parms.Add(new MySqlParameter("hr_horaextra", folha.horaextra));
            parms.Add(new MySqlParameter("hr_saidahoraextra", folha.horasaidahoraextra));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

    }
}
