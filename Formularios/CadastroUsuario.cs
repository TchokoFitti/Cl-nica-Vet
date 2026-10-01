using ClínicaVetForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClínicaVetForms
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioCadastrar usuario = new UsuarioCadastrar();
            usuario.Cpf = mTxtCpf.Text;
            usuario.Nome = txtNome.Text;
            usuario.Estado = listaEstados.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Telefone = mTxtTelefone.Text;
            usuario.CadastrarUsuario(usuario);
        }

        private void mTxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
