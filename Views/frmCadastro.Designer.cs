namespace ProjetoAgenda
{
    partial class frmCadastro
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
            lblNome = new Label();
            tbxNome = new TextBox();
            tbxUsuario = new TextBox();
            lblUsuario = new Label();
            tbxTelefone = new TextBox();
            lblTelefone = new Label();
            tbxConfirm = new TextBox();
            lblConfirm = new Label();
            tbxSenha = new TextBox();
            lblSenha = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(35, 26);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 18);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(35, 47);
            tbxNome.Margin = new Padding(3, 2, 3, 2);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(320, 23);
            tbxNome.TabIndex = 2;
            tbxNome.TextChanged += tbxNome_TextChanged;
            // 
            // tbxUsuario
            // 
            tbxUsuario.Location = new Point(35, 103);
            tbxUsuario.Margin = new Padding(3, 2, 3, 2);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(320, 23);
            tbxUsuario.TabIndex = 4;
            tbxUsuario.TextChanged += tbxUsuario_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(35, 82);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(75, 18);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário";
            // 
            // tbxTelefone
            // 
            tbxTelefone.Location = new Point(35, 160);
            tbxTelefone.Margin = new Padding(3, 2, 3, 2);
            tbxTelefone.Name = "tbxTelefone";
            tbxTelefone.Size = new Size(320, 23);
            tbxTelefone.TabIndex = 6;
            tbxTelefone.TextChanged += tbxTelefone_TextChanged;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(35, 140);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(86, 18);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone";
            // 
            // tbxConfirm
            // 
            tbxConfirm.Location = new Point(35, 272);
            tbxConfirm.Margin = new Padding(3, 2, 3, 2);
            tbxConfirm.Name = "tbxConfirm";
            tbxConfirm.Size = new Size(320, 23);
            tbxConfirm.TabIndex = 8;
            tbxConfirm.TextChanged += tbxConfirm_TextChanged;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirm.Location = new Point(35, 251);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(162, 18);
            lblConfirm.TabIndex = 7;
            lblConfirm.Text = "Confirme a senha";
            // 
            // tbxSenha
            // 
            tbxSenha.Location = new Point(35, 215);
            tbxSenha.Margin = new Padding(3, 2, 3, 2);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.Size = new Size(320, 23);
            tbxSenha.TabIndex = 10;
            tbxSenha.TextChanged += tbxSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(35, 194);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(63, 18);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Enabled = false;
            btnCadastrar.Location = new Point(35, 322);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(147, 44);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(207, 322);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 44);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(420, 412);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(tbxSenha);
            Controls.Add(lblSenha);
            Controls.Add(tbxConfirm);
            Controls.Add(lblConfirm);
            Controls.Add(tbxTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(tbxUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(tbxNome);
            Controls.Add(lblNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCadastro";
            Text = "Cadastro";
            FormClosed += frmCadastro_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox tbxNome;
        private TextBox tbxUsuario;
        private Label lblUsuario;
        private TextBox tbxTelefone;
        private Label lblTelefone;
        private TextBox tbxConfirm;
        private Label lblConfirm;
        private TextBox tbxSenha;
        private Label lblSenha;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}