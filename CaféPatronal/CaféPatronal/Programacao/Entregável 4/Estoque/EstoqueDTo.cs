using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_roupas.DB.Estoque
{
    class EstoqueDTO
    {
        public int id_estoque { get; set; }

        public int id_produtocompra { get; set; }

        public decimal ds_quantidade { get; set; }
    }
}
