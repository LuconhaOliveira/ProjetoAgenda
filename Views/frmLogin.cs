using ProjetoAgenda.Controllers;
using ProjetoAgenda.Views;

namespace ProjetoAgenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            // checa se o tamanho do usuario e senha é maior que o estipulado e habilita o botão caso verdadeiro
            if (tbxUsuario.TextLength > 0 && tbxSenha.TextLength >= 8)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // instanciando tanto o formulario quando a classe
            frmPrincipal frmPrincipal = new frmPrincipal();
            UserController controleUsuario = new UserController();

            // definindo os parametros pra funcao
            string nome = tbxUsuario.Text;
            string senha = tbxSenha.Text;
            
            // checando se tudo deu certo ebaa
            bool resultado = controleUsuario.LoginUser(nome, senha);
            if (resultado == true)
            {
                // abre o form principal se deu certinho
                frmPrincipal.ShowDialog();
                this.Hide();
            }
        }
    }
}
