using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Animal
    {

        public readonly static string INSERTANIMAL = "INSERT INTO Animal (Chip, NomeAnimal, Sexo) VALUES(@Chip, @NomeAnimal, @Sexo)";
        public readonly static string INSERTTIPO = "INSERT INTO TipoAnimal (Chip, Familia, Raca) VALUES(@Chip, @Familia, @Raca)";
        public readonly static string SELECT = "select Chip, NomeAnimal, Familia, Sexo, Raca from Animal, TipoAnimal where Animal.Chip = TipoAnimal.Chip;";
        public readonly static string DELETEANIMAL = "DELETE FROM Animal WHERE Chip = @Chip";
        public readonly static string DELETETIPOANIMAL = "DELETE FROM TipoAnimal WHERE Chip = @Chip";


        public string Chip { get; set; }
        public string NomeAnimal { get; set; }
        public string Familia { get; set; }
        public char Sexo { get; set; }
        public string Raca { get; set; }

        public Animal() { }
        public Animal(string chip, string nomeanimal, string familia, char sexo, string raca)
        {
            Chip = chip;
            NomeAnimal = nomeanimal;
            Familia = familia;
            Sexo = sexo;
            Raca = raca;
        }

        public override string ToString()
        {
            return $"\nDados do Animal:\n" +
                $"Chip do Animal: {Chip}\n" +
                $"Nome do Animal: {NomeAnimal}" +
                $"Espécie: {Familia}\n" +
                $"Sexo: {Sexo}\n" +
                $"Raça: {Raca}\n";
        }


        

    }
}
