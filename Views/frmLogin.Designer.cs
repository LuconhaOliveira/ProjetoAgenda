namespace ProjetoAgenda
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            tbxSenha = new TextBox();
            tbxUsuario = new TextBox();
            btnLogin = new Button();
            btnCadastro = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(70, 31);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(75, 18);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(70, 95);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(63, 18);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // tbxSenha
            // 
            tbxSenha.Location = new Point(70, 116);
            tbxSenha.Margin = new Padding(3, 2, 3, 2);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.Size = new Size(279, 23);
            tbxSenha.TabIndex = 2;
            tbxSenha.UseSystemPasswordChar = true;
            tbxSenha.TextChanged += tbxSenha_TextChanged;
            // 
            // tbxUsuario
            // 
            tbxUsuario.Location = new Point(70, 52);
            tbxUsuario.Margin = new Padding(3, 2, 3, 2);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(279, 23);
            tbxUsuario.TabIndex = 3;
            tbxUsuario.TextChanged += tbxUsuario_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Enabled = false;
            btnLogin.Location = new Point(70, 154);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(136, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(212, 154);
            btnCadastro.Margin = new Padding(3, 2, 3, 2);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(136, 43);
            btnCadastro.TabIndex = 5;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(420, 226);
            Controls.Add(btnCadastro);
            Controls.Add(btnLogin);
            Controls.Add(tbxUsuario);
            Controls.Add(tbxSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSenha;
        private TextBox tbxSenha;
        private TextBox tbxUsuario;
        private Button btnLogin;
        private Button btnCadastro;
    }
}
