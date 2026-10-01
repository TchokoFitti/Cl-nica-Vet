namespace ClínicaVetForms
{
    partial class FrmCadastroUsuario
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
            txtNome = new TextBox();
            lblNome = new Label();
            lblFone = new Label();
            lblEstado = new Label();
            mTxtTelefone = new MaskedTextBox();
            listaEstados = new ComboBox();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            txtCpf = new Label();
            mTxtCpf = new MaskedTextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(49, 146);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(268, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Location = new Point(49, 128);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblFone
            // 
            lblFone.AutoSize = true;
            lblFone.BackColor = Color.Transparent;
            lblFone.Location = new Point(49, 184);
            lblFone.Name = "lblFone";
            lblFone.Size = new Size(55, 15);
            lblFone.TabIndex = 3;
            lblFone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Location = new Point(49, 297);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado";
            // 
            // mTxtTelefone
            // 
            mTxtTelefone.Location = new Point(49, 201);
            mTxtTelefone.Mask = "(00) 00000-0000";
            mTxtTelefone.Name = "mTxtTelefone";
            mTxtTelefone.Size = new Size(268, 23);
            mTxtTelefone.TabIndex = 8;
            mTxtTelefone.MaskInputRejected += mTxtTelefone_MaskInputRejected;
            // 
            // listaEstados
            // 
            listaEstados.FormattingEnabled = true;
            listaEstados.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goiás", "Maranhão", "Mato Grosso do Sul", "Mato Grosso", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            listaEstados.Location = new Point(49, 315);
            listaEstados.Name = "listaEstados";
            listaEstados.Size = new Size(268, 23);
            listaEstados.TabIndex = 10;
            listaEstados.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(242, 426);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(49, 426);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtCpf
            // 
            txtCpf.AutoSize = true;
            txtCpf.Location = new Point(49, 239);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(28, 15);
            txtCpf.TabIndex = 13;
            txtCpf.Text = "CPF";
            // 
            // mTxtCpf
            // 
            mTxtCpf.Location = new Point(49, 257);
            mTxtCpf.Mask = "000.000.000-00";
            mTxtCpf.Name = "mTxtCpf";
            mTxtCpf.Size = new Size(268, 23);
            mTxtCpf.TabIndex = 14;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(49, 357);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 15;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(49, 375);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(265, 23);
            txtSenha.TabIndex = 16;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(361, 642);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(mTxtCpf);
            Controls.Add(txtCpf);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(listaEstados);
            Controls.Add(mTxtTelefone);
            Controls.Add(lblEstado);
            Controls.Add(lblFone);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmCadastroUsuario";
            Text = "Cadastro Usuário";
            Load += CadastroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblFone;
        private Label lblEstado;
        private MaskedTextBox mTxtTelefone;
        private ComboBox listaEstados;
        private Button btnCadastrar;
        private Button btnVoltar;
        private Label txtCpf;
        private MaskedTextBox mTxtCpf;
        private Label lblSenha;
        private TextBox txtSenha;
    }
}