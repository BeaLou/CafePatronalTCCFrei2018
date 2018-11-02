using CaféPatronal.Programacao.Entregável_4.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_roupas.DB.Estoque
{
    class EstoqueBusiness
    {

        public int Salvar(EstoqueDTO dto)
        {

            if (dto.id_produtocompra == 0)
            {
                throw new ArgumentException("Produto não foi reconhecido");
            }

            EstoqueDatabase db = new EstoqueDatabase();
            return db.Salvar(dto);
        }

        public void Remover(int id)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Remover(id);
        }

        public List<EstoqueDTO> Consultar(string estoq)
        {
            EstoqueDatabase db = new EstoqueDatabase();

            return db.Consultar(estoq);
        }
        public List<EstoqueDTO> Listar()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Listar();
        }
        public void Alterar(EstoqueDTO dto)
        {

            EstoqueDatabase db = new EstoqueDatabase();
            db.Alterar(dto);
        }

        public List<vwconsultarestoque> ConsultarEstoque(string produtoestoque)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.ConsultarEstoque(produtoestoque);
        }
        public vwconsultarestoque ConsultarEstoqueView(string produtoestoque)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.ConsultarEstoqueView(produtoestoque);
        }
    }

}
