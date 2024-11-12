using ProjetoAgenda.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frmUsuario : Form
    {
        UserController controller = new UserController();

        public frmUsuario()
        {
            InitializeComponent();
            atualizaDataGrid();
        }

        private void atualizaDataGrid()
        {
            dgvUsers.DataSource = controller.GetUsers();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string user = Convert.ToString(dgvUsers.SelectedRows[0].Cells[0].Value);
            controller.RemoveUser(user);
            atualizaDataGrid();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string user = Convert.ToString(dgvUsers.SelectedRows[0].Cells[0].Value);
            string senha = tbxSenha.Text;
            controller.ModifyPass(user,senha);
            atualizaDataGrid();
        }
    }
}
