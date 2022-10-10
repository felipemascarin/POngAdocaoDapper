using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;
using Model;

namespace Builder
{
    public class AnimalBuilder : iAnimalBuilder
    {
        public Animal animal;

        public void Reset()
        {
            animal = new Animal();
            Console.Clear();
        }
        public void MakeChip()
        {
            Console.WriteLine("Número do chip (4 numeros obrigatoriamente): ");
            int chip = int.Parse(Console.ReadLine());
            animal.Chip = chip.ToString();
        }
        public void MakeNomeAnimal()
        {
            Console.WriteLine("Nome do animal: ");
            animal.NomeAnimal = Console.ReadLine();
        }
        public void MakeFamilia()
        {
            Console.WriteLine("Espécie pertencente (Gato, Cachorro...): ");
            animal.Familia = Console.ReadLine();
        }
        public void MakeSexo()
        {
            Console.WriteLine("Sexo (M / F): ");
            animal.Sexo = char.Parse(Console.ReadLine().ToUpper());
        }
        public void MakeRaca()
        {
            Console.WriteLine("Raça do animal: ");
            animal.Raca = Console.ReadLine();
        }

        public Animal GetResult() { return animal; }
    }
}
