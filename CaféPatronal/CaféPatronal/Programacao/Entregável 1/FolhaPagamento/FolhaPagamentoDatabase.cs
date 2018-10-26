using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.FolhaPagamento
{
    public class FolhaPagamentoDatabase
    {
        public int Salvar(FolhaPagamentoDTO folha)
        {
            string script =
                @"INSERT INTO tb_folhapagamento
                (
                id_folhapagamento,
                id_funcionario,   
                hr_horasextras,
                bt_valetransporte,
                vl_inss,     
                vl_ir,
                vl_fgts,
                vl_ValeTransporte,
                vl_salarioliquido,
                ds_mes,
                dt_pagamento
                )
                VALUES
                (
                @id_folhapagamento,
                @id_funcionario,   
                @hr_horasextras,
                @bt_valetransporte,
                @vl_inss,     
                @vl_ir,
                @vl_fgts,
                @vl_ValeTransporte,
                @vl_salarioliquido,
                @ds_mes,
                @dt_pagamento
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folhapagamento", folha.id_folhapagamento));
            parms.Add(new MySqlParameter("id_funcionario", folha.id_funcionario));
            parms.Add(new MySqlParameter("hr_horasextras", folha.hr_horasextras));
            parms.Add(new MySqlParameter("bt_valetransporte", folha.bt_valetransporte));
            parms.Add(new MySqlParameter("vl_inss", folha.vl_inss));
            parms.Add(new MySqlParameter("vl_ir", folha.vl_ir));
            parms.Add(new MySqlParameter("vl_fgts", folha.vl_fgts));
            parms.Add(new MySqlParameter("vl_ValeTransporte", folha.vl_ValeTransporte));
            parms.Add(new MySqlParameter("vl_salarioliquido", folha.vl_salarioliquido));
            parms.Add(new MySqlParameter("ds_mes", folha.ds_mes));
            parms.Add(new MySqlParameter("dt_pagamento", folha.dt_pagamento));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(FolhaPagamentoDTO folha)
        {
            string script =
           @"UPDATE tb_folhapagamento
                 SET
                  id_funcionario = @id_funcionario,
                  hr_horasextras = @hr_horasextras,
                  bt_valetransporte = @bt_valetransporte,
                  vl_inss = @vl_inss,
                  vl_ir = @vl_ir,
                  vl_fgts = @vl_fgts,
                  vl_ValeTransporte = @vl_ValeTransporte,
                  vl_salarioliquido=@vl_salarioliquido,
                  ds_mes =@ds_mes,
                  dt_pagamento = @dt_pagamento,
                  WHERE id_folhapagamento = @id_folhapagamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folhapagamento", folha.id_folhapagamento));
            parms.Add(new MySqlParameter("id_funcionario", folha.id_funcionario));
            parms.Add(new MySqlParameter("hr_horasextras", folha.hr_horasextras));
            parms.Add(new MySqlParameter("bt_valetransporte", folha.bt_valetransporte));
            parms.Add(new MySqlParameter("vl_inss", folha.vl_inss));
            parms.Add(new MySqlParameter("vl_ir", folha.vl_ir));
            parms.Add(new MySqlParameter("vl_fgts", folha.vl_fgts));
            parms.Add(new MySqlParameter("vl_ValeTransporte", folha.vl_ValeTransporte));
            parms.Add(new MySqlParameter("vl_salarioliquido", folha.vl_salarioliquido));
            parms.Add(new MySqlParameter("ds_mes", folha.ds_mes));
            parms.Add(new MySqlParameter("dt_pagamento", folha.dt_pagamento));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_folhapagamento WHERE id_folhapagamento = @id_folhapagamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folhapagamento", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<FolhaPagamentoDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_folhapagamento";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FolhaPagamentoDTO> folhas = new List<FolhaPagamentoDTO>();
            while (reader.Read())
            {

                FolhaPagamentoDTO novafolha = new FolhaPagamentoDTO();
                novafolha.id_folhapagamento = reader.GetInt32("id_folhapagamento");
                novafolha.id_funcionario = reader.GetInt32("id_funcionario");
                novafolha.hr_horasextras = reader.GetInt32("hr_horasextras");
                novafolha.bt_valetransporte = reader.GetBoolean("bt_valetransporte");
                novafolha.vl_inss = reader.GetDecimal("vl_inss");
                novafolha.vl_ir = reader.GetDecimal("vl_ir");
                novafolha.vl_fgts = reader.GetDecimal("vl_fgts");
                novafolha.vl_ValeTransporte = reader.GetDecimal("vl_ValeTransporte");
                novafolha.vl_salarioliquido = reader.GetDecimal("vl_salarioliquido");
                novafolha.ds_mes = reader.GetString("ds_mes");
                novafolha.dt_pagamento = reader.GetDateTime("dt_pagamento");

                folhas.Add(novafolha);

            }
            reader.Close();
            return folhas;
        }

        public List<VwConsultarFolhapagamento> Consultarmes(string mes)
        {

            string script =
            @"SELECT * FROM vw_consultar_folhapagamento
                   WHERE ds_mes like @ds_mes";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_mes", "%" + mes + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VwConsultarFolhapagamento> folhas = new List<VwConsultarFolhapagamento>();
            while (reader.Read())
            {
                VwConsultarFolhapagamento dto = new VwConsultarFolhapagamento();
                dto.Nome = reader.GetString("nm_nome");
                dto.Departamento = reader.GetString("ds_dpto");
                dto.Mês = reader.GetString("ds_mes");
                dto.SalarioLiquido = reader.GetDecimal("vl_salarioliquido");
                folhas.Add(dto);
            }
            reader.Close();

            return folhas;

        }
    }
}
