using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaféPatronal.Programacao.Produto
{
    public class ProdutoDatabase
    {
        public int Salvar(ProdutoDTO produto)
        {
            string script =
                @"INSERT INTO tb_produto
                (
                id_produto,
                nm_nome,   
                ds_unidade,
                dt_validade
                )
                VALUES
                (
                @id_produto,
                @nm_nome,   
                @ds_unidade,
                @dt_validade
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", produto.id_produto));
            parms.Add(new MySqlParameter("nm_nome", produto.nm_nome));
            parms.Add(new MySqlParameter("ds_unidade", produto.ds_unidade));
            parms.Add(new MySqlParameter("dt_validade", produto.dt_validade));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(ProdutoDTO produto)
        {
            string script =
            @"UPDATE tb_produto
                 SET id_produto = @id_produto,
                  nm_nome = @nm_nome,
                  ds_unidade = @ds_unidade,
                  dt_validade = @dt_validade,
                  WHERE id_produto = @id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", produto.id_produto));
            parms.Add(new MySqlParameter("nm_nome", produto.nm_nome));
            parms.Add(new MySqlParameter("ds_unidade", produto.ds_unidade));
            parms.Add(new MySqlParameter("dt_validade", produto.dt_validade));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_produto WHERE id_produto = @id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ProdutoDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            while (reader.Read())
            {

                ProdutoDTO novoproduto = new ProdutoDTO();
                novoproduto.id_produto = reader.GetInt32("id_produto");
                novoproduto.nm_nome = reader.GetString("nm_nome");
                novoproduto.ds_unidade = reader.GetString("ds_unidade");
                novoproduto.dt_validade = reader.GetDateTime("dt_validade");

                produtos.Add(novoproduto);

            }
            return produtos;
        }

        public List<ProdutoDTO> Consultar(string produto)
        {

            string script =
                @"SELECT * FROM tb_produto
                  WHERE nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", "%" + produto + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            while (reader.Read())
            {

                ProdutoDTO novoproduto = new ProdutoDTO();
                novoproduto.id_produto = reader.GetInt32("id_produto");
                novoproduto.nm_nome = reader.GetString("nm_nome");
                novoproduto.ds_unidade = reader.GetString("ds_unidade");
                novoproduto.dt_validade = reader.GetDateTime("dt_validade");

                produtos.Add(novoproduto);

            }
            return produtos;

        }
    }
}
