namespace ClínicaVetForms
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            gBoxLogin = new GroupBox();
            btnEntrar = new Button();
            linkLblCadastrar = new LinkLabel();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblTítulo = new Label();
            gBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxLogin
            // 
            gBoxLogin.BackColor = Color.Transparent;
            gBoxLogin.Controls.Add(btnEntrar);
            gBoxLogin.Controls.Add(linkLblCadastrar);
            gBoxLogin.Controls.Add(lblSenha);
            gBoxLogin.Controls.Add(txtSenha);
            gBoxLogin.Controls.Add(lblUsuario);
            gBoxLogin.Controls.Add(txtUsuario);
            gBoxLogin.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gBoxLogin.ForeColor = SystemColors.Highlight;
            gBoxLogin.Location = new Point(314, 108);
            gBoxLogin.Name = "gBoxLogin";
            gBoxLogin.Size = new Size(431, 400);
            gBoxLogin.TabIndex = 0;
            gBoxLogin.TabStop = false;
            gBoxLogin.Text = "Login";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(226, 328);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(138, 42);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // linkLblCadastrar
            // 
            linkLblCadastrar.AutoSize = true;
            linkLblCadastrar.Location = new Point(40, 328);
            linkLblCadastrar.Name = "linkLblCadastrar";
            linkLblCadastrar.Size = new Size(138, 42);
            linkLblCadastrar.TabIndex = 1;
            linkLblCadastrar.TabStop = true;
            linkLblCadastrar.Text = "Cadastrar";
            linkLblCadastrar.LinkClicked += linkLblCadastrar_LinkClicked;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(40, 169);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(90, 42);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(40, 224);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(346, 50);
            txtSenha.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(40, 51);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(109, 42);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(40, 96);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(346, 50);
            txtUsuario.TabIndex = 0;
            // 
            // lblTítulo
            // 
            lblTítulo.AutoSize = true;
            lblTítulo.BackColor = Color.Transparent;
            lblTítulo.Font = new Font("Segoe Print", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTítulo.ForeColor = SystemColors.Highlight;
            lblTítulo.Location = new Point(314, 20);
            lblTítulo.Name = "lblTítulo";
            lblTítulo.Size = new Size(323, 85);
            lblTítulo.TabIndex = 0;
            lblTítulo.Text = "Clínica Vet+";
            lblTítulo.Click += lblTítulo_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 35, 236);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1076, 716);
            Controls.Add(lblTítulo);
            Controls.Add(gBoxLogin);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "TelaPrincipal";
            Text = "Clínica Vet+";
            gBoxLogin.ResumeLayout(false);
            gBoxLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBoxLogin;
        private Label lblTítulo;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private Button btnEntrar;
        private LinkLabel linkLblCadastrar;
    }
}
