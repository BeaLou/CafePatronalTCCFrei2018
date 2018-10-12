using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Produto
{
    public class ProdutoBusiness
    {
        ProdutoDatabase db = new ProdutoDatabase();

        public int Salvar(ProdutoDTO produto)
        {
            if (produto.nm_nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }

            if (produto.ds_descricao == string.Empty)
            {
                throw new ArgumentException("Descrição é obrigatório.");
            }
            if (produto.vl_produto <= 0)
            {
                throw new ArgumentException("Valor do produto é inválido.");
            }

            return db.Salvar(produto);

        }

        public void Alterar(ProdutoDTO produto)
        {
            if (produto.nm_nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }

            if (produto.ds_descricao == string.Empty)
            {
                throw new ArgumentException("Descrição é obrigatório.");
            }
            if (produto.vl_produto <= 0)
            {
                throw new ArgumentException("Valor do produto é inválido.");
            }

            db.Alterar(produto);
        }

        public List<ProdutoDTO> Consultar(string produto)
        {
            return db.Consultar(produto);
        }

        public List<ProdutoDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
