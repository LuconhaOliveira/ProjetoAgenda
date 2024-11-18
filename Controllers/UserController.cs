using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoAgenda.Controllers
{
    internal class UserController
    {
        
        public bool AddUser(string nome, string usuario, string telefone, string senha)
        {
            try
            {
                // abrir conexao no sql

                MySqlConnection conexao = ConexaoDb.CriarConexao();

                //inserir dados na tabela do sql
                

                conexao.Open();
                
                string sql = $"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';";
                
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.ExecuteNonQuery();

                sql = $"GRANT SELECT, INSERT, DELETE, UPDATE ON dbagenda.* TO '{usuario}'@'%';";

                comando = new MySqlCommand(sql , conexao);

                comando.ExecuteNonQuery();


                sql = "INSERT INTO tbUsuarios(nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                comando = new MySqlCommand(sql, conexao);

                // definindo os parametros inseridos
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                // ver quantos foram afetados
                int quantidadeAfetada = comando.ExecuteNonQuery();

                conexao.Close();

                if( quantidadeAfetada > 0)
                {
                    // se deu mais que 0, deu certo obviamente
                    return true;
                }
                else
                {
                    return false;
                }

            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro:{erro.Message}");
                return false;
            }
            
        }

        public bool LoginUser(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDb.CriarConexao();

                string sql = "SELECT * FROM tbUsuarios WHERE usuario = @usuario AND BINARY SENHA = @senha;";
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if(resultado.Read())
                {
                    conexao.Close();
                    ConexaoDb.user = usuario;
                    ConexaoDb.senha = senha;
                    return true;
                }
                else
                {
                    conexao.Close();
                    MessageBox.Show("Ocorreu um erro ao entrar! Revise seus dados e tente novamente");
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public DataTable GetUsers()
        {
            MySqlConnection conexao = null;

            try
            {
                DataTable tabela = new DataTable();
                conexao = ConexaoDb.CriarConexao();

                conexao.Open();

                string sql = @"SELECT nome AS 'Nome', 
                            usuario AS 'Úsuario' ,
                            telefone AS 'Telefone'
                            FROM tbUsuarios;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

                adapter.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar úsuarios: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool RemoveUser(string username)
        {
            MySqlConnection conexao = null;

            try
            {
                // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                conexao = ConexaoDb.CriarConexao();

                string sql = "DELETE FROM tbusuario WHERE usuario=@usuario;";

                conexao.Open();

                // adicionando os parametros e executando
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", username);

                // vendo a quantidade afetada e vendo se foi feito com sucesso ou nao
                int quantidadeAfetada = comando.ExecuteNonQuery();

                return true;

            }
            catch (Exception erro)
            {
                // se der erro mostra tlg
                MessageBox.Show($"Erro ao remover úsuario: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool ModifyData(string username, string firstData, string newData)
        {
            MySqlConnection conexao = null;

            try
            {
                // Entrar e criar a conexao no SQL, inserindo o comando previsto na variavel sql
                conexao = ConexaoDb.CriarConexao();

                string sql = "UPDATE tbusuarios SET @first=@new WHERE usuario=@usuario;";

                conexao.Open();

                // adicionando os parametros e executando
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", username);
                comando.Parameters.AddWithValue("@first", firstData);
                comando.Parameters.AddWithValue("@new", newData);

                // vendo a quantidade afetada e vendo se foi feito com sucesso ou nao
                int quantidadeAfetada = comando.ExecuteNonQuery();

                return true;

            }
            catch (Exception erro)
            {
                // se der erro mostra tlg
                MessageBox.Show($"Erro ao alterar a senha do úsuario: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
