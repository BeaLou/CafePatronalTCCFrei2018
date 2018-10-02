using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Dpto
{
 public   class DptoBusiness
    {
        DptoDatabase db = new DptoDatabase();
        public List<DptoDTO> Listar()
        {
            return db.Listar();
        }
    }
}
