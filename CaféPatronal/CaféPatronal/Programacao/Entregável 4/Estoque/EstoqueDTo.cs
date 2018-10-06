using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Estoque
{
    public class EstoqueDTO
    {
        public int id_estoque { get; set; }
        public int id_produto { get; set; }
        public int id_fornecedor { get; set; }
        public decimal vl_compra { get; set; }
        public DateTime dt_datacompra { get; set; }
        public string qtd_produtos { get; set; }
        public DateTime dt_validade { get; set; }
    }
}
