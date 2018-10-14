using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Pedido
{
    public class PedidoDTO
    {
        public int id_pedido { get; set; }
        public int id_cliente { get; set; }
        public DateTime dt_venda { get; set; }
        public string ds_formapagamento { get; set; }
    }
}
