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
            if (folha.faltaprimeira == string.Empty)
            {
                throw new ArgumentException("Faltas da primeira semana são obrigatórias.(Caso não tenha nenhuma 0)");
            }
            if (folha.faltasegunda==string.Empty)
            {
                throw new ArgumentException("Faltas da segunda semana são obrigatórias.(Caso não tenha nenhuma 0)");
            }
            if(folha.faltaterceira==string.Empty)
            {
                throw new ArgumentException("Faltas da terceira semana são obrigatórias.(Caso não tenha nenhuma 0)");
            }
            if (folha.faltaquarta==string.Empty)
            {
                    throw new ArgumentException("Faltas da quarta semana são obrigatórias.(Caso não tenha nenhuma 0)");
            }

            return db.Salvar(folha);
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
