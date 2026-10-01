using ClínicaVetForms.Classes;

namespace ClínicaVetForms
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void lblTítulo_Click(object sender, EventArgs e)
        {

        }

        private void linkLblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmCadastroUsuario telaCadastroUsuario = new FrmCadastroUsuario();
            telaCadastroUsuario.ShowDialog();
            this.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool logado = false;

            string usuarioDigitado = txtUsuario.Text;
            string senhaDigitada = txtSenha.Text;

            UsuarioCadastrar usuario = new UsuarioCadastrar();
            List<UsuarioCadastrar> listaUsuario = usuario.ListaUsuarios;

            if (logado == true)
            {
                // se o usuário e a senha conferem
                this.Hide();
                FrmPaginaInicial frmPaginaInicial = new FrmPaginaInicial();
                frmPaginaInicial.ShowDialog();
                this.Show();
            }
        }
    }
}
