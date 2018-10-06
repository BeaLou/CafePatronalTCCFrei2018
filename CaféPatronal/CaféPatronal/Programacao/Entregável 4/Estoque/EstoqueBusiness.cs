using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Estoque
{
    public class EstoqueBusiness
    {
        EstoqueDatabase db = new EstoqueDatabase();

        public int Salvar(EstoqueDTO estoque)
        {
            if (estoque.vl_compra <= 0)
            {
                throw new ArgumentException("Valor da compra é obrigatório.");
            }
            if (estoque.qtd_produtos == string.Empty)
            {
                throw new ArgumentException("Quantidade de Produtos é obrigatório.");
            }

            if (estoque.dt_validade > DateTime.Now)
            {
                throw new ArgumentException("Data de Validade é inválida.");
            }
            return db.Salvar(estoque);
        }

        public void Alterar(EstoqueDTO estoque)
        {
            if (estoque.vl_compra <= 0)
            {
                throw new ArgumentException("Valor da compra é obrigatório.");
            }
            if (estoque.qtd_produtos == string.Empty)
            {
                throw new ArgumentException("Quantidade de Produtos é obrigatório.");
            }

            if (estoque.dt_validade > DateTime.Now)
            {
                throw new ArgumentException("Data de Validade é inválida.");
            }

            db.Alterar(estoque);
        }

        public List<EstoqueDTO> Consultar(string cliente)
        {
            return db.Consultar(cliente);
        }

        public List<EstoqueDTO> Listar()
        {
            return db.Listar();
        }

        //  public void Remover(int id)
        //  {
        //   db.Remover(id);
        // }
    }
}
