﻿using CaféPatronal.Programacao.ConnectionDB;
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

        public int Salvar(FuncionarioDTO funcionario)
        {
            string script =
                @"INSERT INTO tb_funcionario
                (
                 id_funcionario,
                 
                 nm_nome,
                 nm_sobrenome,
                 ds_carteiratrabalho,
                 ds_cpf,
                 ds_rg,
                 ds_dpto,
                 ds_email,
                 ds_telefone,
                 ds_telefonemovel,
                 ds_cep,
                 ds_complemento,
                 ds_ncasa,
                 dt_nascimento,
                 ds_login,
                 ds_senha,
                 bt_permissaoadm,
                 bt_permissaorh,
                 bt_permissaofuncionario
                )
                VALUES
                (
                 @id_funcionario,
                 
                 @nm_nome,
                 @nm_sobrenome,
                 @ds_carteiratrabalho,
                 @ds_cpf,
                 @ds_rg,
                 @ds_dpto,
                 @ds_email,
                 @ds_telefone,
                 @ds_telefonemovel,
                 @ds_cep,
                 @ds_complemento,
                 @ds_ncasa,
                 @dt_nascimento,
                 @ds_login,
                 @ds_senha,
                 @bt_permissaoadm,
                 @bt_permissaorh,
                 @bt_permissaofuncionario
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", funcionario.id_funcionario));

            parms.Add(new MySqlParameter("nm_nome", funcionario.nm_nome));
            parms.Add(new MySqlParameter("nm_sobrenome", funcionario.nm_sobrenome));
            parms.Add(new MySqlParameter("ds_carteiratrabalho", funcionario.ds_carteiratrabalho));
            parms.Add(new MySqlParameter("ds_cpf", funcionario.ds_cpf));
            parms.Add(new MySqlParameter("ds_rg", funcionario.ds_rg));
            parms.Add(new MySqlParameter("ds_dpto", funcionario.ds_dpto));
            parms.Add(new MySqlParameter("ds_email", funcionario.ds_email));
            parms.Add(new MySqlParameter("ds_telefone", funcionario.ds_telefone));
            parms.Add(new MySqlParameter("ds_telefonemovel", funcionario.ds_telefonemovel));
            parms.Add(new MySqlParameter("ds_cep", funcionario.ds_cep));
            parms.Add(new MySqlParameter("ds_complemento", funcionario.ds_ncasa));
            parms.Add(new MySqlParameter("ds_ncasa", funcionario.ds_ncasa));
            parms.Add(new MySqlParameter("dt_nascimento", funcionario.dt_nascimento));
            parms.Add(new MySqlParameter("ds_login", funcionario.ds_login));
            parms.Add(new MySqlParameter("ds_senha", funcionario.ds_senha));
            parms.Add(new MySqlParameter("bt_permissaoadm", funcionario.bt_permissaoadm));
            parms.Add(new MySqlParameter("bt_permissaorh", funcionario.bt_permissaorh));
            parms.Add(new MySqlParameter("bt_permissaofuncionario", funcionario.bt_permissaofuncionario));
            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(FuncionarioDTO funcionario)
        {
            string script =
            @"UPDATE tb_funcionario
                 SET
                 nm_nome = @nm_nome,
                 nm_sobrenome = @nm_sobrenome,
                 ds_carteiratrabalho = @ds_carteiratrabalho,
                 ds_cpf = @ds_cpf,
                 ds_rg = @ds_rg,
                 ds_dpto = @ds_dpto,
                 ds_email = @ds_email,
                 ds_telefone = @ds_telefone,
                 ds_telefonemovel = @ds_telefonemovel,
                 ds_cep = @ds_cep,
                 ds_complemento = @ds_complemento,
                 ds_ncasa = @ds_ncasa,
                 dt_nascimento = @dt_nascimento,
                 ds_login = @ds_login,
                 ds_senha = @ds_senha,
                 bt_permissaoadm = @bt_permissaoadm,
                 bt_permissaorh = @bt_permissaorh,
                 bt_permissaofuncionario = @bt_permissaofuncionario
                 WHERE id_funcionario = @id_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", funcionario.id_funcionario));

            parms.Add(new MySqlParameter("nm_nome", funcionario.nm_nome));
            parms.Add(new MySqlParameter("nm_sobrenome", funcionario.nm_sobrenome));
            parms.Add(new MySqlParameter("ds_carteiratrabalho", funcionario.ds_carteiratrabalho));
            parms.Add(new MySqlParameter("ds_cpf", funcionario.ds_cpf));
            parms.Add(new MySqlParameter("ds_rg", funcionario.ds_rg));
            parms.Add(new MySqlParameter("ds_dpto", funcionario.ds_dpto));
            parms.Add(new MySqlParameter("ds_email", funcionario.ds_email));
            parms.Add(new MySqlParameter("ds_telefone", funcionario.ds_telefone));
            parms.Add(new MySqlParameter("ds_telefonemovel", funcionario.ds_telefonemovel));
            parms.Add(new MySqlParameter("ds_cep", funcionario.ds_cep));
            parms.Add(new MySqlParameter("ds_complemento", funcionario.ds_ncasa));
            parms.Add(new MySqlParameter("ds_ncasa", funcionario.ds_ncasa));
            parms.Add(new MySqlParameter("dt_nascimento", funcionario.dt_nascimento));
            parms.Add(new MySqlParameter("ds_login", funcionario.ds_login));
            parms.Add(new MySqlParameter("ds_senha", funcionario.ds_senha));
            parms.Add(new MySqlParameter("bt_permissaoadm", funcionario.bt_permissaoadm));
            parms.Add(new MySqlParameter("bt_permissaorh", funcionario.bt_permissaorh));
            parms.Add(new MySqlParameter("bt_permissaofuncionario", funcionario.bt_permissaofuncionario));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_funcionario WHERE id_funcionario = @id_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<FuncionarioDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_funcionario";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (reader.Read())
            {

                FuncionarioDTO novofuncionario = new FuncionarioDTO();
                novofuncionario.id_funcionario = reader.GetInt32("id_funcionario");

                novofuncionario.nm_nome = reader.GetString("nm_nome");
                novofuncionario.nm_sobrenome = reader.GetString("nm_sobrenome");
                novofuncionario.ds_carteiratrabalho = reader.GetString("ds_carteiratrabalho");
                novofuncionario.ds_cpf = reader.GetString("ds_cpf");
                novofuncionario.ds_rg = reader.GetString("ds_rg");
                novofuncionario.ds_dpto = reader.GetString("ds_dpto");
                novofuncionario.ds_email = reader.GetString("ds_email");
                novofuncionario.ds_telefone = reader.GetString("ds_telefone");
                novofuncionario.ds_telefonemovel = reader.GetString("ds_telefonemovel");
                novofuncionario.ds_cep = reader.GetString("ds_cep");
                novofuncionario.ds_complemento = reader.GetString("ds_complemento");
                novofuncionario.ds_ncasa = reader.GetString("ds_ncasa");
                novofuncionario.dt_nascimento = reader.GetDateTime("dt_nascimento");
                novofuncionario.ds_login = reader.GetString("ds_login");
                novofuncionario.ds_senha = reader.GetString("ds_senha");
                novofuncionario.bt_permissaoadm = reader.GetBoolean("bt_permissaoadm");
                novofuncionario.bt_permissaorh = reader.GetBoolean("bt_permissaorh");
                novofuncionario.bt_permissaofuncionario = reader.GetBoolean("bt_permissaofuncionario");

                funcionarios.Add(novofuncionario);

            }
            return funcionarios;
        }

        public List<FuncionarioDTO> Consultar(string funcionario)
        {

            string script =
                @"SELECT * FROM tb_funcionario
                  WHERE nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", "%" + funcionario + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (reader.Read())
            {

                FuncionarioDTO novofuncionario = new FuncionarioDTO();
                novofuncionario.id_funcionario = reader.GetInt32("id_funcionario");

                novofuncionario.nm_nome = reader.GetString("nm_nome");
                novofuncionario.nm_sobrenome = reader.GetString("nm_sobrenome");
                novofuncionario.ds_carteiratrabalho = reader.GetString("ds_carteiratrabalho");
                novofuncionario.ds_cpf = reader.GetString("ds_cpf");
                novofuncionario.ds_rg = reader.GetString("ds_rg");
                novofuncionario.ds_dpto = reader.GetString("ds_dpto");
                novofuncionario.ds_email = reader.GetString("ds_email");
                novofuncionario.ds_telefone = reader.GetString("ds_telefone");
                novofuncionario.ds_telefonemovel = reader.GetString("ds_telefonemovel");
                novofuncionario.ds_cep = reader.GetString("ds_cep");
                novofuncionario.ds_complemento = reader.GetString("ds_complemento");
                novofuncionario.ds_ncasa = reader.GetString("ds_ncasa");
                novofuncionario.dt_nascimento = reader.GetDateTime("dt_nascimento");
                novofuncionario.ds_login = reader.GetString("ds_login");
                novofuncionario.ds_senha = reader.GetString("ds_senha");
                novofuncionario.bt_permissaoadm = reader.GetBoolean("bt_permissaoadm");
                novofuncionario.bt_permissaorh = reader.GetBoolean("bt_permissaorh");
                novofuncionario.bt_permissaofuncionario = reader.GetBoolean("bt_permissaofuncionario");

                funcionarios.Add(novofuncionario);

            }
            return funcionarios;

        }
    }
}