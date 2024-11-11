using MySql.Data.MySqlClient;
using ProjetoAgenda.Controllers;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void habilitarCadastrar()
        {
            bool isValid = false;

            // Checando se os critérios para cadastrar são atendidos

            // Se o campo nome estiver vazio || Se o campo user tiver vazio || Se o campo telefone tiver vazio || Se a senha tiver menos que 8 caracteres|| Se a confirmacao for diferente
            if (tbxNome.Text.Length <= 0 || tbxUsuario.Text.Length <= 0 || tbxTelefone.Text.Length <= 0 || tbxSenha.Text.Length < 8 || tbxConfirm.Text != tbxSenha.Text)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }


            if (isValid == true)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }
        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }
        private void tbxTelefone_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void tbxConfirm_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = tbxNome.Text;
            string usuario = tbxUsuario.Text;
            string telefone = tbxTelefone.Text;
            string senha = tbxSenha.Text;

            UserController userController = new UserController();

            bool resultado = userController.AddUser(nome, usuario, telefone, senha);

            if (resultado == true)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");

            }
            else
            {
                MessageBox.Show("Não foi possível realizar o cadastro");
            }
        }

        private void frmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
