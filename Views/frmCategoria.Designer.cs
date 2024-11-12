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
            tbxDeleta = new TextBox();
            btnDeleta = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Comic Sans MS", 9F);
            btnCadastro.Location = new Point(9, 70);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(155, 57);
            btnCadastro.TabIndex = 11;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // tbxCategoria
            // 
            tbxCategoria.Location = new Point(9, 34);
            tbxCategoria.Name = "tbxCategoria";
            tbxCategoria.Size = new Size(318, 27);
            tbxCategoria.TabIndex = 9;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(9, 6);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(105, 29);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Categoria";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Comic Sans MS", 9F);
            btnCancelar.Location = new Point(172, 70);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 57);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvTabela
            // 
            dgvTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabela.Location = new Point(361, 16);
            dgvTabela.Margin = new Padding(3, 4, 3, 4);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.RowHeadersWidth = 51;
            dgvTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabela.Size = new Size(289, 171);
            dgvTabela.TabIndex = 12;
            // 
            // tbxDeleta
            // 
            tbxDeleta.Location = new Point(9, 164);
            tbxDeleta.Name = "tbxDeleta";
            tbxDeleta.Size = new Size(155, 27);
            tbxDeleta.TabIndex = 9;
            // 
            // btnDeleta
            // 
            btnDeleta.Font = new Font("Comic Sans MS", 9F);
            btnDeleta.Location = new Point(172, 158);
            btnDeleta.Name = "btnDeleta";
            btnDeleta.Size = new Size(75, 33);
            btnDeleta.TabIndex = 11;
            btnDeleta.Text = "Deletar";
            btnDeleta.UseVisualStyleBackColor = true;
            btnDeleta.Click += btnDeleta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 130);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 6;
            label1.Text = "ID para deletar";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(664, 203);
            Controls.Add(dgvTabela);
            Controls.Add(btnDeleta);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastro);
            Controls.Add(tbxDeleta);
            Controls.Add(tbxCategoria);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCategoria";
            Text = "frmAddCategoria";
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
        private TextBox tbxDeleta;
        private Button btnDeleta;
        private Label label1;
    }
}