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
            atualizaDataGrid();
        }

        private void atualizaDataGrid()
        {
            dgvTabela.DataSource = categoriaController.GetCategorias();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string categoria = tbxCategoria.Text;

            bool resultado = categoriaController.AddCategoria(categoria);

            if (resultado == false)
            {
                MessageBox.Show("Não foi possível realizar o cadastro");
            }

            atualizaDataGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
            int deletar = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells[0].Value);
            categoriaController.RemoveCategorias(deletar);
            atualizaDataGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int alterar = Convert.ToInt32(dgvTabela.SelectedRows[0].Cells[0].Value);
            string categoria = tbxCategoria.Text;
            bool resultado=categoriaController.UpdateCategoria(alterar, categoria);
            if (resultado == false)
            {
                MessageBox.Show("Não foi possível alterar categoria");
            }
            atualizaDataGrid();
        }
    }
}
