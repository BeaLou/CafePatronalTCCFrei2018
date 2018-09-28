using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Funcionario
{
    public class FuncionarioBusiness
    {
        FuncionarioDatabase db = new FuncionarioDatabase();
        public FuncionarioDTO Logar(string login, string senha)
        {
            if (login == string.Empty)
            {
                throw new ArgumentException("Usuário é obrigatório.");
            }

            if (senha == string.Empty)
            {
                throw new ArgumentException("Senha é obrigatório.");
            }

            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Logar(login, senha);
        }

        public int Salvar(FuncionarioDTO funcionario)
        {
            if (funcionario.nm_nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }
            if (funcionario.nm_sobrenome == string.Empty)
            {
                throw new ArgumentException("Sobrenome é obrigatório.");
            }
            if (funcionario.ds_carteiratrabalho == string.Empty)
            {
                throw new ArgumentException("Carteira de trabalho é obrigatória.");
            }
            if (funcionario.ds_cpf == string.Empty)
            {
                throw new ArgumentException("CPF é obrigatório.");
            }
            if (funcionario.ds_rg == string.Empty)
            {
                throw new ArgumentException("RG é obrigatório.");
            }
            if (funcionario.ds_dpto == string.Empty)
            {
                throw new ArgumentException("Departamento é obrigatório.");
            }
            if (funcionario.ds_email == string.Empty)
            {
                throw new ArgumentException("Email é obrigatório.");
            }
            if (funcionario.ds_telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
            if (funcionario.ds_telefonemovel == string.Empty)
            {
                throw new ArgumentException("Telefone Móvel é obrigatório.");
            }
            if (funcionario.ds_cep == string.Empty)
            {
                throw new ArgumentException("Cep é obrigatório.");
            }
            if (funcionario.ds_complemento == string.Empty)
            {
                throw new ArgumentException("Complemento é obrigatório.");
            }
            if (funcionario.ds_ncasa == string.Empty)
            {
                throw new ArgumentException("Número da casa é obrigatório.");
            }
            if (funcionario.ds_login == string.Empty)
            {
                throw new ArgumentException("Login para o sistema é obrigatório");
            }
            if (funcionario.ds_senha == string.Empty)
            {
                throw new ArgumentException("Senha para o sistema é obrigatório");
            }
            if (funcionario.dt_nascimento > DateTime.Now)
            {
                throw new ArgumentException("Data não valida");
            }

            if (funcionario.dt_nascimento.Year > 1999)
            {
                throw new ArgumentException("tem que ser maior de 18");
            }

            return db.Salvar(funcionario);

        }

        public void Alterar(FuncionarioDTO funcionario)
        {
            if (funcionario.nm_nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }
            if (funcionario.nm_sobrenome == string.Empty)
            {
                throw new ArgumentException("Sobrenome é obrigatório.");
            }
            if (funcionario.ds_carteiratrabalho == string.Empty)
            {
                throw new ArgumentException("Carteira de trabalho é obrigatória.");
            }
            if (funcionario.ds_cpf == string.Empty)
            {
                throw new ArgumentException("CPF é obrigatório.");
            }
            if (funcionario.ds_rg == string.Empty)
            {
                throw new ArgumentException("RG é obrigatório.");
            }
            if (funcionario.ds_dpto == string.Empty)
            {
                throw new ArgumentException("Departamento é obrigatório.");
            }
            if (funcionario.ds_email == string.Empty)
            {
                throw new ArgumentException("Email é obrigatório.");
            }
            if (funcionario.ds_telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
            if (funcionario.ds_telefonemovel == string.Empty)
            {
                throw new ArgumentException("Telefone Móvel é obrigatório.");
            }
            if (funcionario.ds_cep == string.Empty)
            {
                throw new ArgumentException("Cep é obrigatório.");
            }
            if (funcionario.ds_complemento == string.Empty)
            {
                throw new ArgumentException("Complemento é obrigatório.");
            }
            if (funcionario.ds_ncasa == string.Empty)
            {
                throw new ArgumentException("Número da casa é obrigatório.");
            }
            if (funcionario.ds_login == string.Empty)
            {
                throw new ArgumentException("Login para o sistema é obrigatório");
            }
            if (funcionario.ds_senha == string.Empty)
            {
                throw new ArgumentException("Senha para o sistema é obrigatório");
            }
            if (funcionario.dt_nascimento > DateTime.Now)
            {
                throw new ArgumentException("Data não valida");
            }

            if (funcionario.dt_nascimento.Year > 1999)
            {
                throw new ArgumentException("tem que ser maior de 18");
            }


            db.Alterar(funcionario);
        }

        public List<FuncionarioDTO> Consultar(string funcionario)
        {
            return db.Consultar(funcionario);
        }

        public List<FuncionarioDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
