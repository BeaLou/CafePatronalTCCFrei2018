using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Estoque
{
    public class FornecedroDatabase
    {
        public int Salvar(FornecedorDTO fornecedor)
        {
            string script =
                @"INSERT INTO tb_fornecedor
                (
                id_fornecedor,
                nm_nome,   
                ds_cnpj,
                ds_telefone,
                ds_cep,     
                ds_complemento,
                ds_numerofornec,
                ds_email
                )
                VALUES
                (
                @id_fornecedor,
                @nm_nome,   
                @ds_cnpj,
                @ds_telefone,
                @ds_cep,     
                @ds_complemento,
                @ds_numerofornec,
                @ds_email
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", fornecedor.id_fornecedor));
            parms.Add(new MySqlParameter("nm_nome", fornecedor.nm_nome));
            parms.Add(new MySqlParameter("ds_cnpj", fornecedor.ds_cnpj));
            parms.Add(new MySqlParameter("ds_telefone", fornecedor.ds_telefone));
            parms.Add(new MySqlParameter("ds_cep", fornecedor.ds_cep));
            parms.Add(new MySqlParameter("ds_complemento", fornecedor.ds_complemento));
            parms.Add(new MySqlParameter("ds_numerofornec", fornecedor.ds_numerofornecedor));
            parms.Add(new MySqlParameter("ds_email", fornecedor.ds_email));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(FornecedorDTO fornecedor)
        {
            string script =
            @"UPDATE tb_fornecedor
                 SET 
                  nm_nome = @nm_nome,
                  ds_cnpj = @ds_cnpj,
                  ds_telefone = @ds_telefone,
                  ds_cep = @ds_cep,
                  ds_complemento = @ds_complemento,
                  ds_numerofornec = @ds_numerofornec,
                  ds_email = @ds_email
                  WHERE id_fornecedor = @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", fornecedor.id_fornecedor));
            parms.Add(new MySqlParameter("nm_nome", fornecedor.nm_nome));
            parms.Add(new MySqlParameter("ds_cnpj", fornecedor.ds_cnpj));
            parms.Add(new MySqlParameter("ds_telefone", fornecedor.ds_telefone));
            parms.Add(new MySqlParameter("ds_cep", fornecedor.ds_cep));
            parms.Add(new MySqlParameter("ds_complemento", fornecedor.ds_complemento));
            parms.Add(new MySqlParameter("ds_numerofornec", fornecedor.ds_numerofornecedor));
            parms.Add(new MySqlParameter("ds_email", fornecedor.ds_email));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_fornecedor WHERE id_fornecedor = @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<FornecedorDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_fornecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();
            while (reader.Read())
            {

                FornecedorDTO novofornecedor = new FornecedorDTO();
                novofornecedor.id_fornecedor = reader.GetInt32("id_fornecedor");
                novofornecedor.nm_nome = reader.GetString("nm_nome");
                novofornecedor.ds_cnpj = reader.GetString("ds_cnpj");
                novofornecedor.ds_telefone = reader.GetString("ds_telefone");
                novofornecedor.ds_cep = reader.GetString("ds_cep");
                novofornecedor.ds_complemento = reader.GetString("ds_complemento");
                novofornecedor.ds_numerofornecedor = reader.GetString("ds_numerofornec");
                novofornecedor.ds_email = reader.GetString("ds_email");

                fornecedores.Add(novofornecedor);

            }
            return fornecedores;
        }

        public List<FornecedorDTO> Consultar(string fornecedor)
        {

            string script =
                @"SELECT * FROM tb_fornecedor
                  WHERE nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", "%" + fornecedor + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();
            while (reader.Read())
            {

                FornecedorDTO novofornecedor = new FornecedorDTO();
                novofornecedor.id_fornecedor = reader.GetInt32("id_fornecedor");
                novofornecedor.nm_nome = reader.GetString("nm_nome");
                novofornecedor.ds_cnpj = reader.GetString("ds_cnpj");
                novofornecedor.ds_telefone = reader.GetString("ds_telefone");
                novofornecedor.ds_cep = reader.GetString("ds_cep");
                novofornecedor.ds_complemento = reader.GetString("ds_complemento");
                novofornecedor.ds_numerofornecedor = reader.GetString("ds_numerofornec");
                novofornecedor.ds_email = reader.GetString("ds_email");

                fornecedores.Add(novofornecedor);

            }
            return fornecedores;

        }
    }
}
