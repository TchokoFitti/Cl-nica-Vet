using ClinicaVetForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClínicaVetForms
{
    public partial class FrmCadastrarTutor : Form
    {
        public FrmCadastrarTutor()
        {
            InitializeComponent();
        }

        private void FrmCadastrarTutor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mTxtNome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrarTutor_Click(object sender, EventArgs e)
        {
            //chamar a função cadastrar tutor no meu banco de dados
            Tutor tutorCadastrar = new Tutor();
            tutorCadastrar.Cpf = mTxtCpf.Text;
            tutorCadastrar.Telefone = mTxtFone.Text;
            tutorCadastrar.Email = txtEmail.Text;
            tutorCadastrar.Nome = txtNomeTutor.Text;
            tutorCadastrar.CadastrarTutor(tutorCadastrar);
        }

        private void txtNomeTutor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
