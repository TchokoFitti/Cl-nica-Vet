using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVetForms
{
	public class Consulta
	{
		public int IdConsulta {  get; private set; }
		public string? DataConsulta { get; set; }
		public string? HoraConsulta { get; set; }
		public string? Triagem {  get; set; }
		public string? Situacao { get; set; }

		public Animal animal = new Animal();
		public Tutor tutor = new Tutor();
		public Veterinario veterinario = new Veterinario();

		public void AgendarConsulta(List<Animal> ListaAnimal)
		{
            bool animalExiste = false;

                Console.WriteLine("Digite o id do animal");
                animal.IdAnimal = int.Parse(Console.ReadLine()!);
                foreach (Animal animalCadastrado in ListaAnimal)
                {
                    if (animal.IdAnimal == animalCadastrado.IdAnimal)
                    {
                        animalExiste = true;
                    return;
                    }   
                }
            
                if (animalExiste == false)
                {
                    Console.WriteLine("Animal não cadastrado!");
                }
        }
	}
}