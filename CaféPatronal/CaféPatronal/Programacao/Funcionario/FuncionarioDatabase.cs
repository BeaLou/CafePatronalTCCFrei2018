using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Funcionario
{
    public class FuncionarioDatabase
    {
public FuncionarioDTO Logar(string login, string senha)
        {
            string script = @"SELECT * FROM tb_funcionario WHERE ds_login = @ds_login AND ds_senha = @ds_senha";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_login", login));
            parms.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            FuncionarioDTO funcionario = null;
            if (reader.Read())
            {
                funcionario = new FuncionarioDTO();
                funcionario.id_funcionario = reader.GetInt32("id_funcionario");
                funcionario.id_controleponto = reader.GetInt32("Id_controleponto");
                funcionario.nm_nome = reader.GetString("nm_nome");
                funcionario.nm_sobrenome = reader.GetString("nm_sobrenome");
                funcionario.ds_carteiratrabalho = reader.GetString("ds_carteiratrabalho");
                funcionario.ds_cpf = reader.GetString("ds_cpf");
                funcionario.ds_dpto = reader.GetString("ds_dpto");
                funcionario.ds_email = reader.GetString("ds_email");
                funcionario.ds_telefone = reader.GetString("ds_telefone");
                funcionario.ds_telefonemovel = reader.GetString("ds_telefonemovel");
                funcionario.ds_cep = reader.GetString("ds_cep");
                funcionario.ds_complemento = reader.GetString("ds_complemento");
                funcionario.ds_ncasa = reader.GetString("ds_ncasa");
                funcionario.dt_nascimento = reader.GetDateTime("dt_nascimento");
                funcionario.ds_login = reader.GetString("ds_login");
                funcionario.bt_permissaoadm = reader.GetBoolean("bt_permissaoadm");
                funcionario.bt_permissaorh = reader.GetBoolean("bt_permissaorh");
                funcionario.bt_permissaofuncionario = reader.GetBoolean("bt_permissaofuncionario");

            }
            reader.Close();
            return funcionario;
        }
    }
}
