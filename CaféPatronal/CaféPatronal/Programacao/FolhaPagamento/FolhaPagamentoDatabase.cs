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
                vl_salarioliquido
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
                @vl_salarioliquido
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


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        //public void Alterar(FolhaPagamentoDTO folha)
        //{
        //    string script =
        //    @"UPDATE tb_folhapagamento
        //         SET id_folhapagamento = @id_folhapagamento,
        //          ds_inss = @ds_inss,
        //          ds_valealimentacao = @ds_valealimentacao,
        //          ds_valerefeicao = @ds_valerefeicao,
        //          ds_valetransporte = @ds_valetransporte,
        //          ds_convenio = @ds_convenio,
        //          ds_agua = @ds_agua,
        //          ds_luz = @ds_luz,
        //          ds_telefonnet=@ds_telefonnet,
        //          WHERE id_fornecedor = @id_fornecedor";

        //    List<MySqlParameter> parms = new List<MySqlParameter>();
        //    parms.Add(new MySqlParameter("id_folhapagamento", folha.id_folhapagamento));
        //    parms.Add(new MySqlParameter("ds_inss", folha.ds_inss));
        //    parms.Add(new MySqlParameter("ds_valealimentacao", folha.ds_valealimentacao));
        //    parms.Add(new MySqlParameter("ds_valerefeicao", folha.ds_valerefeicao));
        //    parms.Add(new MySqlParameter("ds_valetransporte", folha.ds_valetransporte));
        //    parms.Add(new MySqlParameter("ds_convenio", folha.ds_convenio));
        //    parms.Add(new MySqlParameter("ds_agua", folha.ds_agua));
        //    parms.Add(new MySqlParameter("ds_luz", folha.ds_luz));
        //    parms.Add(new MySqlParameter("ds_telefonnet", folha.ds_telefonnet));

        //    Database db = new Database();
        //    db.ExecuteInsertScript(script, parms);
        //}


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

                folhas.Add(novafolha);

            }
            return folhas;
        }

        //public List<FolhaPagamentoDTO> Consultar(string folha)
        //{

        //    string script =
        //        @"SELECT * FROM tb_folhapagamento
        //          WHERE id_folhapagamento like @id_folhapagamento";
        //    List<MySqlParameter> parms = new List<MySqlParameter>();
        //    parms.Add(new MySqlParameter("id_folhapagamento", "%" + folha + "%"));
        //    Database db = new Database();
        //    MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
        //    List<FolhaPagamentoDTO> folhas = new List<FolhaPagamentoDTO>();
        //    while (reader.Read())
        //    {

        //        FolhaPagamentoDTO novafolha = new FolhaPagamentoDTO();
        //        novafolha.id_folhapagamento = reader.GetInt32("id_folhapagamento");
        //        novafolha.id_folhaproduto = reader.GetInt32("id_folhaproduto");
        //        novafolha.ds_inss = reader.GetDecimal("ds_inss");
        //        novafolha.ds_valealimentacao = reader.GetDecimal("ds_valealimentacao");
        //        novafolha.ds_valerefeicao = reader.GetDecimal("ds_valerefeicao");
        //        novafolha.ds_valetransporte = reader.GetDecimal("ds_valetransporte");
        //        novafolha.ds_convenio = reader.GetDecimal("ds_convenio");
        //        novafolha.ds_agua = reader.GetDecimal("ds_agua");
        //        novafolha.ds_luz = reader.GetDecimal("ds_luz");
        //        novafolha.ds_telefonnet = reader.GetDecimal("ds_telefonnet");

        //        folhas.Add(novafolha);

        //    }
        //    return folhas;
        //}
    }
}
