using System;
using System.Collections.Generic;
using System.Text;

namespace ClínicaVetForms.Classes
{
    public class UsuarioCadastrar
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Cpf {  get; set; }
        public string? Estado {  get; set; }
        public string? Senha { get; set; }

        public List<UsuarioCadastrar> ListaUsuarios = new List<UsuarioCadastrar>();

        public void CadastrarUsuario(UsuarioCadastrar usuario)
        {

        }
    }

}
