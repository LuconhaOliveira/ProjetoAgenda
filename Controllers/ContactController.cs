using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controllers
{
    internal class ContactController
    {
        public bool AddContato(string nomeContato, string telefone, string categoria)
        {

            MySqlConnection conexao = null;

            try
            {
                // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                conexao = ConexaoDb.CriarConexao();

                string sql = "INSERT INTO tbContatos(nome,telefone,categoria) VALUES (@nomeContato, @telefone, @categoria);";

                conexao.Open();

                // adicionando os parametros e executando
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nomeCtg", nomeContato);
                comando.Parameters.AddWithValue("@telfone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);

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

        public DataTable GetContatos()
        {
            MySqlConnection conexao = null;

            try
            {
                DataTable tabela = new DataTable();
                conexao = ConexaoDb.CriarConexao();

                conexao.Open();

                string sql = @$"SELECT id AS 'Código',
                            nome AS 'Nome',
                            telefone AS 'Telefone',
                            categoria AS 'Categoria' 
                            FROM tbContato WHERE usuario LIKE '{UserSession.user}@%';";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

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

        public bool RemoveContato(int id)
        {
            MySqlConnection conexao = null;

            try
            {
                // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                conexao = ConexaoDb.CriarConexao();

                string sql = "DELETE FROM tbcontatos WHERE id=@id;";

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

        public bool UpdateContato(int id, string alteracao, string campo)
        {

            MySqlConnection conexao = null;

            try
            {
                // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                conexao = ConexaoDb.CriarConexao();

                string sql = "UPDATE tbCategorias SET @campo=@alteracao WHERE id=@id;";

                conexao.Open();

                // adicionando os parametros e executando
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@campo", campo);
                comando.Parameters.AddWithValue("@alteracao", alteracao);
                comando.Parameters.AddWithValue("@id", id);

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
    }
}
