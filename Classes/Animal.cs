using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;

namespace ClinicaVetForms
{
    public class Animal
    {
        public int IdAnimal {  get; set; }
        public string? NomeAnimal { get; set; }
        public string? TipoAnimal { get; set; }
        public string? RacaAnimal { get; set; }
        private string? DataNascimento { get; set; }
        private string? CpfTutor {  get; set; }

        //public Animal(int ctID, string ctNome, string ctTipo, string ctRaca, string ctData, string ctCPF)
        //{
        //    _idAnimal = ctID;
        //    nomeAnimal = ctNome;
        //    tipoAnimal = ctTipo;
        //    racaAnimal = ctRaca;
        //    _dataNascimento = ctData;
        //    _cpfTutor = ctCPF;
        //    Console.WriteLine($" Animal: {nomeAnimal}, do tutor de cpf {_cpfTutor} foi cadastrado.");
        //}

        public Animal CadastrarAnimal() 
        {
            Animal animal = new Animal();
            Console.Write("Digite o nome do animal: ");
            animal.NomeAnimal = Console.ReadLine();
            Console.Write("Digite o tipo do animal: ");
            animal.TipoAnimal = Console.ReadLine();
            Console.Write("Digite a raça do animal: ");
            animal.RacaAnimal = Console.ReadLine();
            Console.Write("Digite a data de nascimento do animal: ");
            animal.DataNascimento = Console.ReadLine();
            Console.Write("Digite o cpf do tutor: ");
            animal.CpfTutor = Console.ReadLine();
            return animal;
        }
    }
}
