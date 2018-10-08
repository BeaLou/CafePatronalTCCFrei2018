using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Produto
{
    public class ProdutoDTO
    {
        public int id_produto { get; set; }
        public string nm_nome { get; set; }
        public string ds_unidade { get; set; }
        public string vl_unidade { get; set; }
        public DateTime dt_validade { get; set; }
    }
}
