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
    public partial class frmCategoria : Form
    {
        CategoriaController categoriaController = new CategoriaController();
        public frmCategoria()
        {
            InitializeComponent();
            dgvTabela.DataSource = categoriaController.GetCategorias();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string categoria = tbxCategoria.Text;

            bool resultado = categoriaController.AddCategoria(categoria);

            if(resultado==false)
            {
                MessageBox.Show("Não foi possível realizar o cadastro");
            }

            dgvTabela.DataSource = categoriaController.GetCategorias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
