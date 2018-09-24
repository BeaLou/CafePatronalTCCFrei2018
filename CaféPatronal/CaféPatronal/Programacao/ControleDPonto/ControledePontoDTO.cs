using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.ControleDPonto
{
    public class ControledePontoDTO
    {
        public int id_controleponto { get; set; }
        public DateTime dt_dia { get; set; }
        public TimeSpan hr_entrada { get; set; }
        public TimeSpan hr_saidaalmoco { get; set; }
        public TimeSpan hr_retornoalmoco { get; set; }
        public TimeSpan hr_saida { get; set; }
        public TimeSpan hr_extra { get; set; }
        public TimeSpan hr_extrasaida { get; set; }
    }
}
