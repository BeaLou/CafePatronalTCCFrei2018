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
            if (folha.ds_inss <= 0)
            {
                throw new ArgumentException("Inss é obrigatório.");
            }
            if (folha.ds_valealimentacao <= 0)
            {
                throw new ArgumentException("Vale alimentação é obrigatório.");
            }
            if (folha.ds_valerefeicao <= 0)
            {
                throw new ArgumentException("Vale refeição é obrigatório.");
            }
            if (folha.ds_valetransporte <= 0)
            {
                throw new ArgumentException("Vale transporte é obrigatório.");
            }
            if (folha.ds_convenio <= 0)
            {
                throw new ArgumentException("Convênio é obrigatório.");
            }
            if (folha.ds_agua <= 0)
            {
                throw new ArgumentException("Água é obrigatório.");
            }
            if (folha.ds_luz <= 0)
            {
                throw new ArgumentException("Luz é obrigatório.");
            }
            if (folha.ds_telefonnet <= 0)
            {
                throw new ArgumentException("Telefone e internet é obrigatório.");
            }
            return db.Salvar(folha);

        }

        public void Alterar(FolhaPagamentoDTO folha)
        {
            if (folha.ds_inss <= 0)
            {
                throw new ArgumentException("Inss é obrigatório.");
            }
            if (folha.ds_valealimentacao <= 0)
            {
                throw new ArgumentException("Vale alimentação é obrigatório.");
            }
            if (folha.ds_valerefeicao <= 0)
            {
                throw new ArgumentException("Vale refeição é obrigatório.");
            }
            if (folha.ds_valetransporte <= 0)
            {
                throw new ArgumentException("Vale transporte é obrigatório.");
            }
            if (folha.ds_convenio <= 0)
            {
                throw new ArgumentException("Convênio é obrigatório.");
            }
            if (folha.ds_agua <= 0)
            {
                throw new ArgumentException("Água é obrigatório.");
            }
            if (folha.ds_luz <= 0)
            {
                throw new ArgumentException("Luz é obrigatório.");
            }
            if (folha.ds_telefonnet <= 0)
            {
                throw new ArgumentException("Telefone e internet é obrigatório.");
            }

            db.Alterar(folha);
        }

        public List<FolhaPagamentoDTO> Consultar(string folha)
        {
            return db.Consultar(folha);
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
