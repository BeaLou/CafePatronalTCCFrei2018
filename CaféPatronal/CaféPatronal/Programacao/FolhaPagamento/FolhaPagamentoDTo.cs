using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.FolhaPagamento
{
    public class FolhaPagamentoDTO
    {
        public int id_folhapagamento { get; set; }
        public int id_folhaproduto { get; set; }
        public decimal ds_inss { get; set; }
        public decimal ds_valealimentacao { get; set; }
        public decimal ds_valerefeicao { get; set; }
        public decimal ds_valetransporte { get; set; }
        public decimal ds_convenio { get; set; }
        public decimal ds_agua { get; set; }
        public decimal ds_luz { get; set; }
        public decimal ds_telefonnet { get; set; }
    }
}
