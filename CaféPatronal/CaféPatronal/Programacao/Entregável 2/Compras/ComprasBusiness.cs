using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_2.Compras
{
   public class ComprasBusiness
    {
        ComprasDatabase db = new ComprasDatabase();

        public int Salvar(ComprasDTO compra)
        {
            if (compra.nm_compra == string.Empty)
            {
                throw new ArgumentException("Nome da compra é obrigatório.");
            }
            if (compra.qtd_unidade == string.Empty)
            {
                throw new ArgumentException("Quantidade é obrigatória.");
            }
            if (compra.vl_compra <= 0)
            {
                throw new ArgumentException("Valor da compra é obrigatório.");
            }

            return db.Salvar(compra);

        }

        public List<ComprasDTO> Consultar(string compra)
        {
            return db.Consultar(compra);
        }

        public List<ComprasDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
