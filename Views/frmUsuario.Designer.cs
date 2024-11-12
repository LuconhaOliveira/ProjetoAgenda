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
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(24, 28);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 29);
            btnDeletar.TabIndex = 0;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(150, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(389, 354);
            dgvUsers.TabIndex = 1;
            // 
            // btnSenha
            // 
            btnSenha.Location = new Point(24, 229);
            btnSenha.Name = "btnSenha";
            btnSenha.Size = new Size(94, 51);
            btnSenha.TabIndex = 2;
            btnSenha.Text = "Alterar senha";
            btnSenha.UseVisualStyleBackColor = true;
            btnSenha.Click += btnSenha_Click;
            // 
            // tbxSenha
            // 
            tbxSenha.Location = new Point(12, 182);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.Size = new Size(125, 27);
            tbxSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 147);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 4;
            label1.Text = "Nova senha";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 359);
            Controls.Add(label1);
            Controls.Add(tbxSenha);
            Controls.Add(btnSenha);
            Controls.Add(dgvUsers);
            Controls.Add(btnDeletar);
            Name = "frmUsuario";
            Text = "frmUsuario";
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
    }
}