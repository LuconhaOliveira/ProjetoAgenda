namespace ProjetoAgenda.Views
{
    partial class frmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastro = new Button();
            tbxCategoria = new TextBox();
            lblUsuario = new Label();
            btnCancelar = new Button();
            dgvTabela = new DataGridView();
            btnDeleta = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Comic Sans MS", 9F);
            btnCadastro.Location = new Point(8, 52);
            btnCadastro.Margin = new Padding(3, 2, 3, 2);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(136, 43);
            btnCadastro.TabIndex = 11;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // tbxCategoria
            // 
            tbxCategoria.Location = new Point(8, 26);
            tbxCategoria.Margin = new Padding(3, 2, 3, 2);
            tbxCategoria.Name = "tbxCategoria";
            tbxCategoria.Size = new Size(279, 23);
            tbxCategoria.TabIndex = 9;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(8, 4);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 23);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Categoria";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Comic Sans MS", 9F);
            btnCancelar.Location = new Point(150, 52);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 43);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvTabela
            // 
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Location = new Point(316, 12);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.RowHeadersWidth = 51;
            dgvTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabela.Size = new Size(253, 128);
            dgvTabela.TabIndex = 12;
            // 
            // btnDeleta
            // 
            btnDeleta.Font = new Font("Comic Sans MS", 9F);
            btnDeleta.Location = new Point(150, 99);
            btnDeleta.Margin = new Padding(3, 2, 3, 2);
            btnDeleta.Name = "btnDeleta";
            btnDeleta.Size = new Size(137, 41);
            btnDeleta.TabIndex = 11;
            btnDeleta.Text = "Deletar";
            btnDeleta.UseVisualStyleBackColor = true;
            btnDeleta.Click += btnDeleta_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Comic Sans MS", 9F);
            btnUpdate.Location = new Point(8, 99);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 41);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Alterar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(581, 152);
            Controls.Add(dgvTabela);
            Controls.Add(btnUpdate);
            Controls.Add(btnDeleta);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastro);
            Controls.Add(tbxCategoria);
            Controls.Add(lblUsuario);
            Name = "frmCategoria";
            Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private TextBox tbxCategoria;
        private Label lblUsuario;
        private Button btnCancelar;
        private DataGridView dgvTabela;
        private Button btnDeleta;
        private Button btnUpdate;
    }
}