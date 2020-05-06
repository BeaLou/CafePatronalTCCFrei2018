using CaféPatronal.Programacao.ConnectionDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                ds_descricao,
                vl_produto
                )
                VALUES
                (
                @id_produto,
                @nm_nome,   
                @ds_descricao,
                @vl_produto
                )";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_produto", produto.id_produto));
            parms.Add(new SqlParameter("nm_nome", produto.nm_nome));
            parms.Add(new SqlParameter("ds_descricao", produto.ds_descricao));
            parms.Add(new SqlParameter("vl_produto", produto.vl_produto));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(ProdutoDTO produto)
        {
            string script =
            @"UPDATE tb_produto
                 SET
                  nm_nome = @nm_nome,
                  ds_descricao = @ds_descricao,
                  vl_produto=@vl_produto
                  WHERE id_produto = @id_produto";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_produto", produto.id_produto));
            parms.Add(new SqlParameter("nm_nome", produto.nm_nome));
            parms.Add(new SqlParameter("ds_descricao", produto.ds_descricao));
            parms.Add(new SqlParameter("vl_produto", produto.vl_produto));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_produto WHERE id_produto = @id_produto";

            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("id_produto", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ProdutoDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_produto";
            List<SqlParameter> parms = new List<SqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            while (reader.Read())
            {

                ProdutoDTO novoproduto = new ProdutoDTO();
                novoproduto.id_produto = reader.GetInt32("id_produto");
                novoproduto.nm_nome = reader.GetString("nm_nome");
                novoproduto.ds_descricao = reader.GetString("ds_descricao");
                novoproduto.vl_produto = reader.GetDecimal("vl_produto");

                produtos.Add(novoproduto);

            }
            reader.Close();
            return produtos;
        }

        public List<ProdutoDTO> Consultar(string produto)
        {

            string script =
                @"SELECT * FROM tb_produto
                  WHERE nm_nome like @nm_nome";
            List<SqlParameter> parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("nm_nome", "%" + produto + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            while (reader.Read())
            {

                ProdutoDTO novoproduto = new ProdutoDTO();
                novoproduto.id_produto = reader.GetInt32("id_produto");
                novoproduto.nm_nome = reader.GetString("nm_nome");
                novoproduto.ds_descricao = reader.GetString("ds_descricao");
                novoproduto.vl_produto = reader.GetDecimal("vl_produto");

                produtos.Add(novoproduto);

            }
            reader.Close();
            return produtos;

        }
    }
}
