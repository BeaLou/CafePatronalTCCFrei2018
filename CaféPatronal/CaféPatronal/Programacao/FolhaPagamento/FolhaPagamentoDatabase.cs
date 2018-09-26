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
                id_folhaproduto,   
                ds_inss,
                ds_valealimentacao,
                ds_valerefeicao,     
                ds_valetransporte,
                ds_convenio,
                ds_agua,
                ds_luz,
                ds_telefonnet
                )
                VALUES
                (
                @id_folhapagamento,
                @id_folhaproduto,   
                @ds_inss,
                @ds_valealimentacao,
                @ds_valerefeicao,     
                @ds_valetransporte,
                @ds_convenio,
                @ds_agua,
                @ds_luz,
                @ds_telefonnet
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folhapagamento", folha.id_folhapagamento));
            parms.Add(new MySqlParameter("id_folhaproduto", folha.id_folhaproduto));
            parms.Add(new MySqlParameter("ds_inss", folha.ds_inss));
            parms.Add(new MySqlParameter("ds_valealimentacao", folha.ds_valealimentacao));
            parms.Add(new MySqlParameter("ds_valerefeicao", folha.ds_valerefeicao));
            parms.Add(new MySqlParameter("ds_valetransporte", folha.ds_valetransporte));
            parms.Add(new MySqlParameter("ds_convenio", folha.ds_convenio));
            parms.Add(new MySqlParameter("ds_agua", folha.ds_agua));
            parms.Add(new MySqlParameter("ds_luz", folha.ds_luz));
            parms.Add(new MySqlParameter("ds_telefonnet", folha.ds_telefonnet));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(FolhaPagamentoDTO folha)
        {
            string script =
            @"UPDATE tb_folhapagamento
                 SET id_folhapagamento = @id_folhapagamento,
                  ds_inss = @ds_inss,
                  ds_valealimentacao = @ds_valealimentacao,
                  ds_valerefeicao = @ds_valerefeicao,
                  ds_valetransporte = @ds_valetransporte,
                  ds_convenio = @ds_convenio,
                  ds_agua = @ds_agua,
                  ds_luz = @ds_luz,
                  ds_telefonnet=@ds_telefonnet,
                  WHERE id_fornecedor = @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folhapagamento", folha.id_folhapagamento));
            parms.Add(new MySqlParameter("ds_inss", folha.ds_inss));
            parms.Add(new MySqlParameter("ds_valealimentacao", folha.ds_valealimentacao));
            parms.Add(new MySqlParameter("ds_valerefeicao", folha.ds_valerefeicao));
            parms.Add(new MySqlParameter("ds_valetransporte", folha.ds_valetransporte));
            parms.Add(new MySqlParameter("ds_convenio", folha.ds_convenio));
            parms.Add(new MySqlParameter("ds_agua", folha.ds_agua));
            parms.Add(new MySqlParameter("ds_luz", folha.ds_luz));
            parms.Add(new MySqlParameter("ds_telefonnet", folha.ds_telefonnet));

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
                novafolha.id_folhaproduto = reader.GetInt32("id_folhaproduto");
                novafolha.ds_inss = reader.GetDecimal("ds_inss");
                novafolha.ds_valealimentacao = reader.GetDecimal("ds_valealimentacao");
                novafolha.ds_valerefeicao = reader.GetDecimal("ds_valerefeicao");
                novafolha.ds_valetransporte = reader.GetDecimal("ds_valetransporte");
                novafolha.ds_convenio = reader.GetDecimal("ds_convenio");
                novafolha.ds_agua = reader.GetDecimal("ds_agua");
                novafolha.ds_luz = reader.GetDecimal("ds_luz");
                novafolha.ds_telefonnet = reader.GetDecimal("ds_telefonnet");
                folhas.Add(novafolha);

            }
            return folhas;
        }

        public List<FolhaPagamentoDTO> Consultar(string folha)
        {

            string script =
                @"SELECT * FROM tb_folhapagamento
                  WHERE id_folhapagamento like @id_folhapagamento";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folhapagamento", "%" + folha + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FolhaPagamentoDTO> folhas = new List<FolhaPagamentoDTO>();
            while (reader.Read())
            {

                FolhaPagamentoDTO novafolha = new FolhaPagamentoDTO();
                novafolha.id_folhapagamento = reader.GetInt32("id_folhapagamento");
                novafolha.id_folhaproduto = reader.GetInt32("id_folhaproduto");
                novafolha.ds_inss = reader.GetDecimal("ds_inss");
                novafolha.ds_valealimentacao = reader.GetDecimal("ds_valealimentacao");
                novafolha.ds_valerefeicao = reader.GetDecimal("ds_valerefeicao");
                novafolha.ds_valetransporte = reader.GetDecimal("ds_valetransporte");
                novafolha.ds_convenio = reader.GetDecimal("ds_convenio");
                novafolha.ds_agua = reader.GetDecimal("ds_agua");
                novafolha.ds_luz = reader.GetDecimal("ds_luz");
                novafolha.ds_telefonnet = reader.GetDecimal("ds_telefonnet");

                folhas.Add(novafolha);

            }
            return folhas;
        }
    }
}
