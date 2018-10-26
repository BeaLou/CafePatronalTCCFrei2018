using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.FluxoCaixa
{
    public class FluxoCaixaBusiness
    {
        FluxoCaixaDatabase db = new FluxoCaixaDatabase();
        public List<FluxoCaixaVw> Consultar(DateTime Inicio, DateTime Fim)
        {
            return db.Consultar(Inicio, Fim);
        }
    }
}
