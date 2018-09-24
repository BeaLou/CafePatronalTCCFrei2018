using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Cliente
{
  public  class ClienteDTO
    {
        public int id_cliente { get; set; }
        public string nm_nome { get; set; }
        public string nm_sobrenome { get; set; }
        public DateTime dt_datanascimento { get; set; }
        public string ds_cpf { get; set; }
        public string ds_email { get; set; }
    }
}
