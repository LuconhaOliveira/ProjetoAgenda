using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAgenda.VariableGlobal;


namespace ProjetoAgenda.Data
{
    static internal class ConexaoDb
    {

        static public MySqlConnection CriarConexao()
        {
            // string com os dados para conectar
            string stringConexao = $"Server=localhost;Database=dbAgenda;User ID={UserSession.user};Password={UserSession.senha}";

            // conectando
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }

        static public MySqlConnection CriarConexaoRoot()
        {
            // string com os dados para conectar
            string stringConexao = $"Server=localhost;Database=dbAgenda;User ID=root;Password=root";

            // conectando
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }


    }


}
