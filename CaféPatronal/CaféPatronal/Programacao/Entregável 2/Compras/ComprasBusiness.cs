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
            if (compra.dt_compra == DateTime.Now)
            {
                throw new ArgumentException("Nome da compra é obrigatório.");
            }

            return db.Salvar(compra);

        }

        //public int SalvarItem(CompraItemDTO produto, List<ComprasDTO> compras)
        //{



        //    int id_compra = produto.id_compra;


        //    CompraItemBusiness itemBusiness = new CompraItemBusiness();
        //    foreach (ComprasDTO item in compras)
        //    {
        //        CompraItemDTO itemDto = new CompraItemDTO();
        //        itemDto.id_compra = item.id_compra;
        //        itemDto.id_produtocompra = id_produtocompra;

        //        itemBusiness.Salvar(itemDto);
        //    }

        //    return id_produtocompra;
        //}

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
