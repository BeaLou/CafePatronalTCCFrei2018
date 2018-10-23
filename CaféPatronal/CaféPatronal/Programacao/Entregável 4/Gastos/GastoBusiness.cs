using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Entregável_4.Gastos
{
    public class GastoBusiness
    {
        GastoDatabase db = new GastoDatabase();

        public int Salvar(GastoDTO dto)
        {

            if (dto.Gasto == string.Empty)
            {
                throw new ArgumentException("Gasto é obrigatório", "Lottus Store");
            }
            if (dto.Tipo == string.Empty)
            {
                throw new ArgumentException("Tipo é obrigatório", "Lottus Store");
            }
            if (dto.Valor == 0)
            {
                throw new ArgumentException("Valor é obrigatório", "Lottus Store");
            }
            if (dto.Pagamento > DateTime.Now)
            {
                throw new ArgumentException("Data muito avançada", "Lottus Store");
            }

            return db.Salvar(dto);
        }
        public List<GastoDTO> Consultar(string gasto)
        {
            return db.Consultar(gasto);
        }
        public List<GastoDTO> Listar()
        {
            return db.Listar();
        }
        public void Remover(int id)
        {
            db.Remover(id);
        }
        public void Alterar(GastoDTO dto)
        {
            db.Alterar(dto);
        }
    }
}
