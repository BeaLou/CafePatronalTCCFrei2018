using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_4.Gastos
{
    public class GastoDTO
    {
        public int Id { get; set; }

        public string Gasto { get; set; }

        public string Tipo { get; set; }

        public DateTime Pagamento { get; set; }

        public decimal Valor { get; set; }
    }
}
