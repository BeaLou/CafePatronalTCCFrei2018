using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.ControlePagamento
{
  public  class CpDTO
    {
        public int id_controlefolhapagamento { get; set; }
        public DateTime dia { get; set; }
        public DateTime horaentrada { get; set; }
        public DateTime horasaida { get; set; }
        public DateTime horaalmoco { get; set; }
        public DateTime horaretornoalmoco { get; set; }
        public DateTime horaextra { get; set; }
        public DateTime horasaidahoraextra { get; set; }
    }
}
