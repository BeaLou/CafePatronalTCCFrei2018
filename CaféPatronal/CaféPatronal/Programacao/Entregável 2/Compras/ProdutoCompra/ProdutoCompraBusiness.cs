using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_2.Compras.ProdutoCompra
{
    class ProdutoCompraBusiness
    {
        ProdutoCompraDatabase db = new ProdutoCompraDatabase();

        public int Salvar(ProdutoCompraDTO produtoCompra)
        {
            if (produtoCompra.nm_produtocompra == String.Empty)
            {
                throw new ArgumentException("Nome da compra de produto é obrigatório.");
            }
            if (produtoCompra.vl_valor <= 0)
            {
                throw new ArgumentException("Valor da compra de produto é obrigatório.");
            }

            return db.Salvar(produtoCompra);

        }
    }
}
