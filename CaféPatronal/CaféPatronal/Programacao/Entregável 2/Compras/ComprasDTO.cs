using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_2.Compras
{
  public  class ComprasDTO
    {
        public int id_compra { get; set; }
        public int id_fornecedor { get; set; }
        public string nm_compra { get; set; }
        public int qtd_unidade { get; set; }
        public decimal vl_compra { get; set; }
        public DateTime dt_compra { get; set; }
    }
}
