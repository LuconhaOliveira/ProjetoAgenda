namespace ProjetoAgenda.Views
{
    partial class frmAgenda
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
            groupBox1 = new GroupBox();
            cbxCategoria = new ComboBox();
            lblContato = new Label();
            lblTelefone = new Label();
            lblCategoria = new Label();
            btnApaga = new Button();
            btnCadastra = new Button();
            btnAltera = new Button();
            txtCategoria = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvContato = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContato).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxCategoria);
            groupBox1.Controls.Add(lblContato);
            groupBox1.Controls.Add(lblTelefone);
            groupBox1.Controls.Add(lblCategoria);
            groupBox1.Controls.Add(btnApaga);
            groupBox1.Controls.Add(btnCadastra);
            groupBox1.Controls.Add(btnAltera);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(11, 135);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(258, 23);
            cbxCategoria.TabIndex = 9;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(11, 28);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 8;
            lblContato.Text = "Contato";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(11, 72);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(11, 117);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria";
            // 
            // btnApaga
            // 
            btnApaga.Location = new Point(145, 255);
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(124, 64);
            btnApaga.TabIndex = 5;
            btnApaga.Text = "Apagar";
            btnApaga.UseVisualStyleBackColor = true;
            btnApaga.Click += btnApaga_Click;
            // 
            // btnCadastra
            // 
            btnCadastra.Location = new Point(11, 185);
            btnCadastra.Name = "btnCadastra";
            btnCadastra.Size = new Size(124, 63);
            btnCadastra.TabIndex = 4;
            btnCadastra.Text = "Cadastrar";
            btnCadastra.UseVisualStyleBackColor = true;
            btnCadastra.Click += btnCadastra_Click;
            // 
            // btnAltera
            // 
            btnAltera.Location = new Point(145, 185);
            btnAltera.Name = "btnAltera";
            btnAltera.Size = new Size(124, 64);
            btnAltera.TabIndex = 3;
            btnAltera.Text = "Alterar";
            btnAltera.UseVisualStyleBackColor = true;
            btnAltera.Click += btnAltera_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(11, 243);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(258, 23);
            txtCategoria.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(11, 90);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(258, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(11, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(258, 23);
            txtNome.TabIndex = 0;
            // 
            // dgvContato
            // 
            dgvContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContato.Location = new Point(334, 12);
            dgvContato.Name = "dgvContato";
            dgvContato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContato.Size = new Size(366, 329);
            dgvContato.TabIndex = 1;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 353);
            Controls.Add(dgvContato);
            Controls.Add(groupBox1);
            Name = "frmAgenda";
            Text = "frmAgenda";
            Load += frmAgenda_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvContato;
        private Label lblContato;
        private Label lblTelefone;
        private Label lblCategoria;
        private Button btnApaga;
        private Button btnCadastra;
        private Button btnAltera;
        private TextBox txtCategoria;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private ComboBox cbxCategoria;
    }
}