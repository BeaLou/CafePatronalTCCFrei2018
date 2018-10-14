using CaféPatronal.Programacao.PedidoItem;
using CaféPatronal.Programacao.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Pedido
{
    public class PedidoBusiness
    {
        PedidoDatabase db = new PedidoDatabase();

        public int Salvar(PedidoDTO pedido)
        {
            if (pedido.ds_formapagamento == string.Empty)
            {
                throw new ArgumentException("Forma de Pagamento é obrigatória.");
            }

            if (pedido.dt_venda < DateTime.Now)
            {
                throw new ArgumentException("Data da Venda é obrigatória.");
            }
            
            return db.Salvar(pedido);

        }
        public int SalvarItem(PedidoDTO pedido, List<ProdutoDTO> produtos)
        {
            PedidoDatabase pedidoDatabase = new PedidoDatabase();
            int idPedido = pedidoDatabase.Salvar(pedido);

            PedidoItemBusiness itemBusiness = new PedidoItemBusiness();
            foreach (ProdutoDTO item in produtos)
            {
                PedidoItemDTO itemDto = new PedidoItemDTO();
                itemDto.id_pedido = idPedido;
                itemDto.id_produto = item.id_produto;

                itemBusiness.Salvar(itemDto);
            }

            return idPedido;
        }



        public void Alterar(PedidoDTO pedido)
        {
            if (pedido.ds_formapagamento == string.Empty)
            {
                throw new ArgumentException("Forma de Pagamento é obrigatória.");
            }

            if (pedido.dt_venda < DateTime.Now)
            {
                throw new ArgumentException("Data da Venda é obrigatória.");
            }

            db.Alterar(pedido);
        }

        public List<PedidoDTO> Consultar(string pedido)
        {
            return db.Consultar(pedido);
        }

        public List<PedidoDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }   
}
   