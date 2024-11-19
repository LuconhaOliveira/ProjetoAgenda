using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;

namespace ProjetoAgenda.Controllers
{
    internal class CategoriaController
    {
        public bool AddCategoria(string nomeCtg)
        {

            MySqlConnection conexao = null;

            try
            {
                // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                conexao = ConexaoDb.CriarConexao();

                string sql = "INSERT INTO tbCategorias (categoria) VALUES (@nomeCtg);";

                conexao.Open();

                // adicionando os parametros e executando
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nomeCtg", nomeCtg);

                // vendo a quantidade afetada e vendo se foi feito com sucesso ou nao
                int quantidadeAfetada = comando.ExecuteNonQuery();

                return true;

            }
            catch (Exception erro)
            {
                // se der erro mostra tlg
                MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
       
        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;

            try
            {
                DataTable tabela = new DataTable();
                conexao = ConexaoDb.CriarConexao();

                conexao.Open();

                string sql = @$"SELECT id AS 'Código', 
                            categoria AS 'Categoria' 
                            FROM tbCategorias WHERE usuario LIKE '{UserSession.user}@%';";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql,conexao);

                adapter.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar categorias: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
            
        }

        public bool RemoveCategorias(int id)
        {
            MySqlConnection conexao = null;

            try
            {
                // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                conexao = ConexaoDb.CriarConexao();

                string sql = "DELETE FROM tbcategorias WHERE id=@id;";

                conexao.Open();

                // adicionando os parametros e executando
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", id);

                // vendo a quantidade afetada e vendo se foi feito com sucesso ou nao
                int quantidadeAfetada = comando.ExecuteNonQuery();

                return true;

            }
            catch (Exception erro)
            {
                // se der erro mostra tlg
                MessageBox.Show($"Erro ao remover categoria: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}