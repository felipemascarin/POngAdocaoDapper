using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adocao
    {

        public readonly static string INSERT = "INSERT INTO Adocao (Chip, CPF, DataAdocao) VALUES(@Chip, @CPF, @DataAdocao)";
        public readonly static string SELECT = "SELECT Chip, CPF, DataAdocao FROM Adocao";
        public readonly static string DELETE = "DELETE FROM Adocao WHERE Chip = @Chip";

        public string Chip { get; set; }
        public string CPF { get; set; }
        public DateTime DataAdocao { get; set; }

        public Adocao() { }

        public Adocao(string chip, string cpf, DateTime dataAdocao)
        {
            Chip = chip;
            CPF = cpf;
            DataAdocao = dataAdocao;
        }

        public override string ToString()
        {
            return $"\nDados da Adoção:\n" +
                $"CPF do Adotante: {CPF}\n" +
                $"Chip do Animal Adotado: {Chip}\n" +
                $"Data da Adoção: {DataAdocao}\n";
        }


    }
}
