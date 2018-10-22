using mecanica.DB.Programação.Estoque;
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
               
            if (dto.id_compra == 0)
            {
                throw new ArgumentException("Produto não foi reconhecido", "Américas Mecânica");
            }


            EstoqueDatabase db = new EstoqueDatabase();
            return db.Salvar(dto);
        }
        public void Alterar(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Alterar(dto);
        }

        public List<EstoqueDTO> Listar()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Listar();
        }

        public void Remover(int id)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Remover(id);
        }


        public List<vwEstoque> Consultar(string nome)
        {
            EstoqueDatabase estoque = new EstoqueDatabase();
            return estoque.Consultar(nome);
        }
    }
}
