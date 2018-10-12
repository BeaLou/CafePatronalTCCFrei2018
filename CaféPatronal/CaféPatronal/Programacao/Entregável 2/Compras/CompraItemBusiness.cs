using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_2.Compras
{
    class CompraItemBusiness
    {
        CompraItemDatabase db = new CompraItemDatabase();

        public int Salvar(CompraItemDTO compra)
        {
            return db.Salvar(compra);
        }

        public void Alterar(CompraItemDTO compra)
        {

            db.Alterar(compra);
        }

        public List<CompraItemDTO> Consultar(string produto)
        {
            return db.Consultar(produto);
        }

        public List<CompraItemDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
