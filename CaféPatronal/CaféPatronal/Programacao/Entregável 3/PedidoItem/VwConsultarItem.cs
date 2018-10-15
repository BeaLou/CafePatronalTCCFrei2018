using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_3.PedidoItem
{
     public class VwConsultarItem
    {
        public int id_pedido { get; set; }
        public string  nm_nome { get; set; }
        public DateTime dt_venda { get; set; }
        public string ds_formapagamento { get; set; }
        public int qtd_itens { get; set; }
        public decimal vl_total { get; set; }
    }
}
