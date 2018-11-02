using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_2.Compras
{
    public class VwConsultarItem
    {
        public int id_compra { get; set; }

        public string nm_produtocompra { get; set; }

        public int qtd_itens { get; set; }

        public decimal vl_total { get; set; }

        public int id_produtocompra { get; set; }

        public DateTime dt_compra { get; set; }

    }
}
