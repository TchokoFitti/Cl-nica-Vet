using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClinicaVetForms
{
    public class Tutor
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }

        List<Animal> ListaAnimais = new List<Animal>();

        //public Tutor(string ctCpf, string ctNome, string ctTelefone, string ctEmail): base(ctNome, ctTelefone, ctEmail)
        //{
        //    nome = ctNome;
        //    telefone = ctTelefone;
        //    email = ctEmail;
        //    cpf = ctCpf;
        //}

        public void CadastrarTutor(Tutor tutor)
        {
            
        }

    }
}
