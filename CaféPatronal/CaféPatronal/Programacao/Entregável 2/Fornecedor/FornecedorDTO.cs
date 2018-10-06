using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Estoque
{
    public class FornecedorDTO
    {
        public int id_fornecedor { get; set; }
        public string nm_nome { get; set; }
        public string ds_cnpj { get; set; }
        public string ds_telefone { get; set; }
        public string ds_cep { get; set; }
        public string ds_complemento { get; set; }
        public string ds_numerofornecedor { get; set; }
        public string ds_email { get; set; }
    }
}
