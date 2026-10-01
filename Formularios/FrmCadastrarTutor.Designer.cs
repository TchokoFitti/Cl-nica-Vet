namespace ClínicaVetForms
{
    partial class FrmCadastrarTutor
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
            lblEmail = new Label();
            lblFone = new Label();
            mTxtFone = new MaskedTextBox();
            mTxtCpf = new MaskedTextBox();
            lblCpf = new Label();
            btnCadastrarTutor = new Button();
            txtNomeTutor = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(96, 61);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(96, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Completo";
            lblNome.Click += label1_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(96, 182);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblFone
            // 
            lblFone.AutoSize = true;
            lblFone.Location = new Point(96, 245);
            lblFone.Name = "lblFone";
            lblFone.Size = new Size(52, 15);
            lblFone.TabIndex = 4;
            lblFone.Text = "Telefone";
            // 
            // mTxtFone
            // 
            mTxtFone.Location = new Point(96, 263);
            mTxtFone.Mask = "(00)00000-0000";
            mTxtFone.Name = "mTxtFone";
            mTxtFone.Size = new Size(114, 23);
            mTxtFone.TabIndex = 8;
            mTxtFone.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // mTxtCpf
            // 
            mTxtCpf.BackColor = Color.White;
            mTxtCpf.Location = new Point(96, 138);
            mTxtCpf.Mask = "000.000.000-00";
            mTxtCpf.Name = "mTxtCpf";
            mTxtCpf.Size = new Size(114, 23);
            mTxtCpf.TabIndex = 10;
            mTxtCpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(96, 120);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 9;
            lblCpf.Text = "CPF";
            // 
            // btnCadastrarTutor
            // 
            btnCadastrarTutor.BackColor = Color.Blue;
            btnCadastrarTutor.FlatAppearance.BorderColor = Color.White;
            btnCadastrarTutor.ForeColor = SystemColors.Control;
            btnCadastrarTutor.Location = new Point(309, 336);
            btnCadastrarTutor.Name = "btnCadastrarTutor";
            btnCadastrarTutor.Size = new Size(75, 23);
            btnCadastrarTutor.TabIndex = 11;
            btnCadastrarTutor.Text = "Cadastrar";
            btnCadastrarTutor.UseVisualStyleBackColor = false;
            btnCadastrarTutor.Click += btnCadastrarTutor_Click;
            // 
            // txtNomeTutor
            // 
            txtNomeTutor.Location = new Point(96, 79);
            txtNomeTutor.Name = "txtNomeTutor";
            txtNomeTutor.Size = new Size(227, 23);
            txtNomeTutor.TabIndex = 12;
            txtNomeTutor.TextChanged += txtNomeTutor_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 23);
            txtEmail.TabIndex = 13;
            // 
            // FrmCadastrarTutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(450, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtNomeTutor);
            Controls.Add(btnCadastrarTutor);
            Controls.Add(mTxtCpf);
            Controls.Add(lblCpf);
            Controls.Add(mTxtFone);
            Controls.Add(lblFone);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmCadastrarTutor";
            Text = "FrmCadastrarTutor";
            Load += FrmCadastrarTutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblFone;
        private MaskedTextBox mTxtFone;
        private MaskedTextBox mTxtCpf;
        private Label lblCpf;
        private Button btnCadastrarTutor;
        private TextBox txtNomeTutor;
        private TextBox txtEmail;
    }
}