namespace ProjetoAgenda.Views
{
    partial class frmUsuario
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
            btnDeletar = new Button();
            dgvUsers = new DataGridView();
            btnSenha = new Button();
            tbxSenha = new TextBox();
            label1 = new Label();
            btnNome = new Button();
            tbxNome = new TextBox();
            label2 = new Label();
            btnTel = new Button();
            tbxTel = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(21, 21);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(82, 22);
            btnDeletar.TabIndex = 0;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(251, 1);
            dgvUsers.Margin = new Padding(3, 2, 3, 2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(310, 287);
            dgvUsers.TabIndex = 1;
            // 
            // btnSenha
            // 
            btnSenha.Location = new Point(21, 110);
            btnSenha.Margin = new Padding(3, 2, 3, 2);
            btnSenha.Name = "btnSenha";
            btnSenha.Size = new Size(82, 38);
            btnSenha.TabIndex = 2;
            btnSenha.Text = "Alterar senha";
            btnSenha.UseVisualStyleBackColor = true;
            btnSenha.Click += btnSenha_Click;
            // 
            // tbxSenha
            // 
            tbxSenha.Location = new Point(10, 86);
            tbxSenha.Margin = new Padding(3, 2, 3, 2);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.Size = new Size(110, 23);
            tbxSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 68);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Nova senha";
            // 
            // btnNome
            // 
            btnNome.Location = new Point(129, 182);
            btnNome.Margin = new Padding(3, 2, 3, 2);
            btnNome.Name = "btnNome";
            btnNome.Size = new Size(82, 38);
            btnNome.TabIndex = 2;
            btnNome.Text = "Alterar nome";
            btnNome.UseVisualStyleBackColor = true;
            btnNome.Click += btnNome_Click;
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(118, 158);
            tbxNome.Margin = new Padding(3, 2, 3, 2);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(110, 23);
            tbxNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 140);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Novo nome";
            // 
            // btnTel
            // 
            btnTel.Location = new Point(24, 236);
            btnTel.Margin = new Padding(3, 2, 3, 2);
            btnTel.Name = "btnTel";
            btnTel.Size = new Size(82, 38);
            btnTel.TabIndex = 2;
            btnTel.Text = "Alterar telefone";
            btnTel.UseVisualStyleBackColor = true;
            btnTel.Click += btnTel_Click;
            // 
            // tbxTel
            // 
            tbxTel.Location = new Point(14, 212);
            tbxTel.Margin = new Padding(3, 2, 3, 2);
            tbxTel.Name = "tbxTel";
            tbxTel.Size = new Size(110, 23);
            tbxTel.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 194);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Nova telefone";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 290);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxTel);
            Controls.Add(btnTel);
            Controls.Add(tbxNome);
            Controls.Add(btnNome);
            Controls.Add(tbxSenha);
            Controls.Add(btnSenha);
            Controls.Add(dgvUsers);
            Controls.Add(btnDeletar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmUsuario";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeletar;
        private DataGridView dgvUsers;
        private Button btnSenha;
        private TextBox tbxSenha;
        private Label label1;
        private Button btnNome;
        private TextBox tbxNome;
        private Label label2;
        private Button btnTel;
        private TextBox tbxTel;
        private Label label3;
    }
}