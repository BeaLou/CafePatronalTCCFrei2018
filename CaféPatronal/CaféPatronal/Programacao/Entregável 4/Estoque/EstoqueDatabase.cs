using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_roupas.DB.Estoque
{
    class EstoqueDatabase
    {
        public int Salvar(EstoqueDTO dto)
        {
            string script =
                @"INSERT INTO tb_estoque
                (id_produtocompra, ds_quantidade)
                VALUES
                (@id_produtocompra, @ds_quantidade)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", dto.id_produtocompra));
            parms.Add(new MySqlParameter("ds_quantidade", dto.ds_quantidade));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }



        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_estoque WHERE id_produtocompra = @id_produtocompra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


    }
}
