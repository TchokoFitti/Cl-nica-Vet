using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVetForms
{
    public class Veterinario
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Crmv { get; set;}
        public string? Especialidade { get; set; }

        //public Veterinario(string ctNome, string ctTelefone, string ctEmail, string ctCrmv, string ctEspecialidade) : base(ctNome, ctTelefone, ctEmail)
        //{
        //    crmv = ctCrmv;
        //    especialidade = ctEspecialidade;
        //}

        public void CadastrarVeterinario()
        {

        } 
    }
}
