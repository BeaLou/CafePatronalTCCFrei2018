using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao
{
    public class FolhadePontoDTO
    {
        public int id_folhaponto { get; set; }
        public int id_controledeponto { get; set; }
        public DateTime dt_mes { get; set; }
        public TimeSpan hr_totalhoras { get; set; }
    }
}
