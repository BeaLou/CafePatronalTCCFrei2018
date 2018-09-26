using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Cliente
{
    public class ClienteBusiness
    {
        ClienteDatabase db = new ClienteDatabase();

        public int Salvar(ClienteDTO cliente)
        {
            if (cliente.nm_nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }
            if (cliente.nm_sobrenome == string.Empty)
            {
                throw new ArgumentException("Sobrenome é obrigatório.");
            }
            if (cliente.ds_cpf == string.Empty)
            {
                throw new ArgumentException("CPF é obrigatório.");
            }
            if (cliente.ds_email == string.Empty)
            {
                throw new ArgumentException("Email é obrigatório");
            }
            if (cliente.dt_datanascimento > DateTime.Now)
            {
                throw new ArgumentException("Data não valida");
            }

            if (cliente.dt_datanascimento.Year > 1999)
            {
                throw new ArgumentException("tem que ser maior de 18");
            }

            return db.Salvar(cliente);

        }

        public void Alterar(ClienteDTO cliente)
        {
            if (cliente.nm_nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }
            if (cliente.nm_sobrenome == string.Empty)
            {
                throw new ArgumentException("Sobrenome é obrigatório.");
            }
            if (cliente.ds_cpf == string.Empty)
            {
                throw new ArgumentException("CPF é obrigatório.");
            }
            if (cliente.ds_email == string.Empty)
            {
                throw new ArgumentException("Email é obrigatório");
            }
            if (cliente.dt_datanascimento > DateTime.Now)
            {
                throw new ArgumentException("Data não valida");
            }

            if (cliente.dt_datanascimento.Year > 1999)
            {
                throw new ArgumentException("tem que ser maior de 18");
            }

            db.Alterar(cliente);
        }

        public List<ClienteDTO> Consultar(string cliente)
        {
            return db.Consultar(cliente);
        }

        public List<ClienteDTO> Listar()
        {
            return db.Listar();
        }

        //  public void Remover(int id)
        //  {
        //   db.Remover(id);
        // }
    }
}
