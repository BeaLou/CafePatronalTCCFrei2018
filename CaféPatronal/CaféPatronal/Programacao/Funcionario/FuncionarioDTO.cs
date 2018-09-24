using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Funcionario
{
    public class FuncionarioDTO
    {
        public int id_funcionario { get; set; }
        public int id_controleponto { get; set; }
        public string nm_nome { get; set; }
        public string nm_sobrenome { get; set; }
        public string ds_carteiratrabalho { get; set; }
        public string ds_cpf { get; set; }
        public string ds_rg { get; set; }
        public string ds_dpto { get; set; }
        public string ds_email { get; set; }
        public string ds_telefone { get; set; }
        public string ds_telefonemovel { get; set; }
        public string ds_cep { get; set; }
        public string ds_complemento { get; set; }
        public string ds_ncasa { get; set; }
        public DateTime dt_nascimento { get; set; }
        public string ds_login { get; set; }
        public string ds_senha { get; set; }
    }
}
