using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Funcionario
{
    public class FuncionarioBusiness
    {
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
    }
}
