using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mecanica.DB.Programação.Estoque
{
    class vwEstoque
    {
        public int Id { get; set; }

        public string Fornecedor { get; set; }

        public string Compra { get; set; }

        public int Quantidade { get; set; }

        public DateTime Data { get; set; }


    }
}
