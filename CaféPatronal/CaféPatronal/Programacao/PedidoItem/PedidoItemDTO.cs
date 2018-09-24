using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.PedidoItem
{
    public class PedidoItemDTO
    {
        public int id_produtoitem { get; set; }
        public int id_produto { get; set; }
        public int id_pedido { get; set; }
    }
}
