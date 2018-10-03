using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.ControlePagamento
{
    public class CpBusiness
    {
        CpDatabase db = new CpDatabase();

        public int Salvar(CpDTO folha)
        {
            if (folha.dia == null)
            {
                throw new ArgumentException("Dia é obrigatório.");
            }
            if (folha.horaalmoco == null)
            {
                throw new ArgumentException("Hora de almoço é obrigatório.");
            }
            if (folha.horaretornoalmoco == null)
            {
                throw new ArgumentException("Hora de retorno do almoço é obrigatório.");
            }
            if (folha.horaentrada == null)
            {
                throw new ArgumentException("Hora de entrada é obrigatório.");
            }
            if (folha.horasaida == null)
            {
                throw new ArgumentException("Hora de saída é obrigatório.");
            }
            if (folha.horaextra == null)
            {
                throw new ArgumentException("Hora extra é obrigatório.");
            }
            if (folha.horasaidahoraextra == null)
            {
                throw new ArgumentException("Saida da hora extra é obrigatório.");
            }

            return db.Salvar(folha);

        }
    }
}
