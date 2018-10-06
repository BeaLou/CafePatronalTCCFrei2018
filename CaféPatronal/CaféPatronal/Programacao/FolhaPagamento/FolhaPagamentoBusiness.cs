using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.FolhaPagamento
{
    public class FolhaPagamentoBusiness
    {
        FolhaPagamentoDatabase db = new FolhaPagamentoDatabase();

        public int Salvar(FolhaPagamentoDTO folha)
        {
            
            return db.Salvar(folha);

        }

        public void Alterar(FolhaPagamentoDTO folha)
        {
         
        }

        public List<VwConsultarFolhapagamento> Consultarmes(string mes)
        {
            return db.Consultarmes(mes);
        }

        public List<FolhaPagamentoDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
