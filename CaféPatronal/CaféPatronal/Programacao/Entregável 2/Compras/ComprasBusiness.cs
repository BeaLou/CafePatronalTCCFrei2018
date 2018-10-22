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
            if (compra.qtd_unidade == 0)
            {
                throw new ArgumentException("Quantidade é obrigatória.");
            }
            if (compra.vl_compra <= 0)
            {
                throw new ArgumentException("Valor da compra é obrigatório.");
            }

            return db.Salvar(compra);

        }
        public int SalvarItem(CompraItemDTO produto, List<ComprasDTO> compras)
        {



            int idproduto = produto.id_produto;


            CompraItemBusiness itemBusiness = new CompraItemBusiness();
            foreach (ComprasDTO item in compras)
            {
                CompraItemDTO itemDto = new CompraItemDTO();
                itemDto.id_compra = item.id_compra;
                itemDto.id_produto = idproduto;

                itemBusiness.Salvar(itemDto);
            }

            return idproduto;
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
