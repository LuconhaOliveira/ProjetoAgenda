using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.VariableGlobal
{
    public static class UserSession
    {
        private static string _user = "root";
        private static string _senha = "root";
        private static string _nome = null;

        public static string user
        {
            get { return _user; }
            set { _user = value; }
        }

        public static string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public static string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
