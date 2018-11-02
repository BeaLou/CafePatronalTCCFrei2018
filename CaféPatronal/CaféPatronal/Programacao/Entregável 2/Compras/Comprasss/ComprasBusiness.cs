using CaféPatronal.Programacao.Entregável_2.Compras.ProdutoCompra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_2.Compras
{
    class ComprasBusiness
    {
        ComprasDatabase db = new ComprasDatabase();

        public int Salvar(ComprasDTO compra, List<ProdutoCompraDTO> produtos)
        {
            int idCompra = db.Salvar(compra);

            CompraItemBusiness compraitemBusiness = new CompraItemBusiness();
            foreach (ProdutoCompraDTO item in produtos)
            {
                CompraItemDTO compraitemDTO = new CompraItemDTO();
                compraitemDTO.id_compra = idCompra;
                compraitemDTO.id_produtocompra = item.id_produtocompra;

                compraitemBusiness.Salvar(compraitemDTO);
            }
            return idCompra;
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
