using CaféPatronal.Programacao.Entregável_3.PedidoItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.PedidoItem
{
    public class PedidoItemBusiness
    {
        PedidoItemDatabase db = new PedidoItemDatabase();

        public int Salvar(PedidoItemDTO pedidoitem)
        {
            return db.Salvar(pedidoitem);
        }

        public void Alterar(PedidoItemDTO pedidoitem)
        {

            db.Alterar(pedidoitem);
        }

        public List<PedidoItemDTO> Consultar(string pedidoitem)
        {
            return db.Consultar(pedidoitem);
        }

        public List<PedidoItemDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
        public List<VwConsultarItem> ConsultarItem (int comandaid)
        {
            if(comandaid == null)
            {
                comandaid = 0;
            }

            return db.ConsultarItem(comandaid);
        }
        public List<VwConsultarItem> ListarItem()
        {
            return db.ListarItem();
        }
    }
}
