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
   