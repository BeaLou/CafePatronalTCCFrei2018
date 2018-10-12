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
        public string ds_descricao { get; set; }
        public decimal vl_produto { get; set; }
    }
}
