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

        public int id_funcionario { get; set; }

        public int hr_horasextras { get; set; }

        public Boolean bt_valetransporte { get; set; }

        public decimal vl_inss { get; set; }

        public decimal vl_ir { get; set; }

        public decimal vl_fgts { get; set; }

        public decimal vl_ValeTransporte { get; set; }

        public decimal vl_salarioliquido { get; set; }
        public string ds_mes { get; set; }

        public DateTime dt_pagamento { get; set; }

        public string faltaprimeira { get; set; }
        public string faltasegunda { get; set; }
        public string faltaterceira { get; set; }
        public string faltaquarta { get; set; }
    }
}
