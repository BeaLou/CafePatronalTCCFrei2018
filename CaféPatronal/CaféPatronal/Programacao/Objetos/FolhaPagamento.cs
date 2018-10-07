using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Objetos
{
    public class FolhaPagamento
    {
        public decimal ValordeDesconto;

        public decimal CalcularValorPorHora(decimal SalarioBruto, int HorasTrabalhadas)
        {
            decimal resposta = SalarioBruto / HorasTrabalhadas;

            return resposta;
        }

        public decimal CalcularValorHoraExtra(decimal ValorDaHora, decimal Porcentagem, int horasextras)
        {
            decimal Horaextra = (ValorDaHora * (Porcentagem / 100)) + ValorDaHora;

            Horaextra = horasextras * Horaextra;

            return Horaextra;
        }

        public int CalcularDiasTrabalhados(int Faltas1semana, int faltas2semana, int Faltas3semana, int Faltas4semana)
        {
            if (Faltas1semana > 0)
            {
                Faltas1semana = Faltas1semana + 1;
            }
            if (faltas2semana > 0)
            {
                faltas2semana = faltas2semana + 1;
            }
            if (Faltas3semana > 0)
            {
                Faltas3semana = Faltas3semana + 1;
            }
            if (Faltas4semana > 0)
            {
                Faltas4semana = Faltas4semana + 1;
            }


            int totaldefaltas = Faltas1semana + faltas2semana + Faltas3semana + Faltas4semana;
            int diastrabalhados = 26 - totaldefaltas;

            return diastrabalhados;
        }

        public int CalcularFinaisdeSemanas(int Faltas1semana, int faltas2semana, int Faltas3semana, int Faltas4semana)
        {
            int finaisdesemanaperdido = 0;


            if (Faltas1semana == 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (faltas2semana == 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (Faltas3semana == 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (Faltas4semana == 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }

            return finaisdesemanaperdido;
        }

        public decimal CalcularDSR(decimal TotalHorasExtras, int DiasTrabalhados, int FinaisDeSemana)
        {
            decimal DSR = TotalHorasExtras / DiasTrabalhados * FinaisDeSemana;

            return DSR;
        }

        public decimal CalcularINSS(decimal SalarioBruto, decimal TotalSalarioBruto)
        {
            decimal PorcentagemINSS = 0;
            if (SalarioBruto <= 1693.72m)
            {
                PorcentagemINSS = 8;
            }
            if (SalarioBruto >= 1693.73m && SalarioBruto <= 2822.90m)
            {
                PorcentagemINSS = 9;
            }
            if (SalarioBruto >= 2822.91m && SalarioBruto <= 5645.80m)
            {
                PorcentagemINSS = 11;
            }

            decimal INSS = TotalSalarioBruto * (PorcentagemINSS / 100);

            return INSS;
        }

        public decimal CalcularIR(decimal TotalSalarioBruto, decimal ValorINSS)
        {
            decimal PorcentagemIR = 0;

            TotalSalarioBruto = TotalSalarioBruto - ValorINSS;

            if (TotalSalarioBruto >= 1903.99m && TotalSalarioBruto <= 2826.65m)
            {
                PorcentagemIR = 7.5m;
                ValordeDesconto = 142.80m;
            }
            if (TotalSalarioBruto >= 2826.66m && TotalSalarioBruto <= 3751.05m)
            {
                PorcentagemIR = 15;
                ValordeDesconto = 354.80m;
            }
            if (TotalSalarioBruto >= 3751.06m && TotalSalarioBruto <= 4664.68m)
            {
                PorcentagemIR = 22.5m;
                ValordeDesconto = 636.13m;
            }
            if (TotalSalarioBruto > 4664.69m)
            {
                PorcentagemIR = 27.5m;
                ValordeDesconto = 869.36m;
            }

            decimal valordescontado = TotalSalarioBruto * (PorcentagemIR / 100);
            decimal IR = valordescontado - ValordeDesconto;

            return IR;
        }

        public decimal CalcularFGTS(decimal SalarioBrutoTotal)
        {
            decimal FGTS = SalarioBrutoTotal * 0.08m;
            return FGTS;
        }

        public int CalcularTotalDeFaltas(int Faltas1semana, int faltas2semana, int Faltas3semana, int Faltas4semana)
        {
            int finaisdesemanaperdido = 0;


            if (Faltas1semana > 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (faltas2semana > 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (Faltas3semana > 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (Faltas4semana > 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }

            int totalfaltas = Faltas1semana + faltas2semana + Faltas3semana + Faltas4semana + finaisdesemanaperdido;
            return totalfaltas;

        }
    }
}
