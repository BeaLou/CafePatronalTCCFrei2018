using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Estoque
{
    public class FOrnecedorBusiness
    {
        FornecedroDatabase db = new FornecedroDatabase();

        public int Salvar(FornecedorDTO fornecedor)
        {
            if (fornecedor.nm_nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }
            if (fornecedor.ds_cnpj == string.Empty)
            {
                throw new ArgumentException("Cnpj é obrigatório.");
            }
            if (fornecedor.ds_telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
            if (fornecedor.ds_cep == string.Empty)
            {
                throw new ArgumentException("Cep é obrigatório.");
            }
            if (fornecedor.ds_complemento == string.Empty)
            {
                throw new ArgumentException("Complemento é obrigatório.");
            }
            if (fornecedor.ds_numerofornecedor == string.Empty)
            {
                throw new ArgumentException("Número é obrigatório.");
            }
            if (fornecedor.ds_email == string.Empty)
            {
                throw new ArgumentException("Email é obrigatório.");
            }

            return db.Salvar(fornecedor);

        }

        public void Alterar(FornecedorDTO fornecedor)
        {
            if (fornecedor.nm_nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }
            if (fornecedor.ds_cnpj == string.Empty)
            {
                throw new ArgumentException("Cnpj é obrigatório.");
            }
            if (fornecedor.ds_telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
            if (fornecedor.ds_cep == string.Empty)
            {
                throw new ArgumentException("Cep é obrigatório.");
            }
            if (fornecedor.ds_complemento == string.Empty)
            {
                throw new ArgumentException("Complemento é obrigatório.");
            }
            if (fornecedor.ds_numerofornecedor == string.Empty)
            {
                throw new ArgumentException("Número é obrigatório.");
            }
            if (fornecedor.ds_email == string.Empty)
            {
                throw new ArgumentException("Email é obrigatório.");
            }

            db.Alterar(fornecedor);
        }

        public List<FornecedorDTO> Consultar(string fornecedor)
        {
            return db.Consultar(fornecedor);
        }

        public List<FornecedorDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
