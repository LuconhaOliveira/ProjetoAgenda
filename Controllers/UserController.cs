using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string sql = "INSERT INTO tbUsuarios(nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

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
    }
}
