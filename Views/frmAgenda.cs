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
    public partial class frmAgenda : Form
    {
        ContactController contactController = new ContactController();

        public frmAgenda()
        {
            InitializeComponent();
            atualizaDataGrid();
        }

        private void atualizaDataGrid()
        {
            dgvContato.DataSource = contactController.GetContatos();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string categoria = txtCategoria.Text;

            bool resultado = contactController.AddContato(nome, telefone, categoria);

            if (resultado == false)
            {
                MessageBox.Show("Não foi possivel realizar o cadastro");
            }

            atualizaDataGrid();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            int deletar = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);
            contactController.RemoveContato(deletar);
            atualizaDataGrid();

        }

        private void btnAltera_Click(object sender, EventArgs e)
        {


            atualizaDataGrid();
        }
    }
}
