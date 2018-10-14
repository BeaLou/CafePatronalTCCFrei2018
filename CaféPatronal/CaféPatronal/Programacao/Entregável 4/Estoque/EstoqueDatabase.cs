using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Estoque
{
    public class EstoqueDatabase
    {
        public int Salvar(EstoqueDTO estoque)
        {
            string script =
                @"INSERT INTO tb_estoque
                (
                    id_estoque,
                    id_produto,
                    id_fornecedor,
                    vl_compra,
                    dt_datacompra,
                    qtd_produtos,
                    dt_validade
                )
                VALUES
                (
                    @id_estoque,
                    @id_produto,
                    @id_fornecedor,
                    @vl_compra,
                    @dt_datacompra,
                    @qtd_produtos,
                    @dt_validade
                    )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estoque", estoque.id_estoque));
            parms.Add(new MySqlParameter("id_produto", estoque.id_produto));
            parms.Add(new MySqlParameter("id_fornecedor", estoque.id_fornecedor));
            parms.Add(new MySqlParameter("vl_compra", estoque.vl_compra));
            parms.Add(new MySqlParameter("dt_datacompra", estoque.dt_datacompra));
            parms.Add(new MySqlParameter("qtd_produtos", estoque.qtd_produtos));
            parms.Add(new MySqlParameter("dt_validade", estoque.dt_validade));
            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(EstoqueDTO estoque)
        {
            string script =
            @"UPDATE tb_estoque
                 SET id_estoque = @id_estoque,
                  id_produto= @id_produto,
                  id_fornecedor = @id_fornecedor,
                  vl_compra= @vl_compra,
                  dt_datacompra= @dt_datacompra,
                  qtd_produtos= @qtd_produtos,
                  dt_validade= @dt_validade,
                  WHERE id_estoque = @id_estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estoque", estoque.id_estoque));
            parms.Add(new MySqlParameter("id_produto", estoque.id_produto));
            parms.Add(new MySqlParameter("id_fornecedor", estoque.id_fornecedor));
            parms.Add(new MySqlParameter("vl_compra", estoque.vl_compra));
            parms.Add(new MySqlParameter("dt_datacompra", estoque.dt_datacompra));
            parms.Add(new MySqlParameter("qtd_produtos", estoque.qtd_produtos));
            parms.Add(new MySqlParameter("dt_validade", estoque.dt_validade));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        // public void Remover(int id)
        // {
        //  string script =
        //  @"DELETE FROM tb_produto WHERE id_produto = @id_produto";

        //  List<MySqlParameter> parms = new List<MySqlParameter>();
        //  parms.Add(new MySqlParameter("id_produto", id));

        //   Database db = new Database();
        //   db.ExecuteInsertScript(script, parms);
        //  }

        public List<EstoqueDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EstoqueDTO> estoques = new List<EstoqueDTO>();
            while (reader.Read())
            {

                EstoqueDTO novoestoque = new EstoqueDTO();
                novoestoque.id_estoque = reader.GetInt32("id_estoque");
                novoestoque.id_produto = reader.GetInt32("id_produto");
                novoestoque.id_fornecedor = reader.GetInt32("id_fornecedor");
                novoestoque.vl_compra = reader.GetDecimal("vl_compra");
                novoestoque.dt_datacompra = reader.GetDateTime("dt_datacompra");
                novoestoque.qtd_produtos = reader.GetString("qtd_produtos");
                novoestoque.dt_validade = reader.GetDateTime("dt_validade");

                estoques.Add(novoestoque);

            }
            reader.Close();
            return estoques;
        }

        public List<EstoqueDTO> Consultar(string estoque)
        {

            string script =
                @"SELECT * FROM tb_estoque
                  WHERE id_produto like @id_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", "%" + estoque + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<EstoqueDTO> estoques = new List<EstoqueDTO>();
            while (reader.Read())
            {

                EstoqueDTO novoestoque = new EstoqueDTO();
                novoestoque.id_estoque = reader.GetInt32("id_estoque");
                novoestoque.id_produto = reader.GetInt32("id_produto");
                novoestoque.id_fornecedor = reader.GetInt32("id_fornecedor");
                novoestoque.vl_compra = reader.GetDecimal("vl_compra");
                novoestoque.dt_datacompra = reader.GetDateTime("dt_datacompra");
                novoestoque.qtd_produtos = reader.GetString("qtd_produtos");
                novoestoque.dt_validade = reader.GetDateTime("dt_validade");

                estoques.Add(novoestoque);

            }
            reader.Close();
            return estoques;

        }
    }
}
