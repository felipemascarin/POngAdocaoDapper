using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adotante
    {

        public readonly static string INSERT = "INSERT INTO Adotante (CPF, NomeAdotante, DataNascimento, Sexo) VALUES(@CPF, @NomeAdotante, @DataNascimento, @Sexo)";
        public readonly static string SELECT = "SELECT CPF, NomeAdotante, DataNascimento, Sexo FROM Adotante";
        public readonly static string DELETE = "DELETE FROM Adotante WHERE CPF = @CPF";


        public string CPF { get; set; }
        public string NomeAdotante { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }

        public Adotante() { }

        public Adotante(string cpf, string nomeAdotante, DateTime dataNascimento, char sexo)
        {
            CPF = cpf;
            NomeAdotante = nomeAdotante;
            DataNascimento = dataNascimento;
            Sexo = sexo;
        }


        public override string ToString()
        {
            return $"\nDados do Adotante:\n" +
                $"CPF do Adotante: {CPF}\n" +
                $"Nome do Adotante: {NomeAdotante}" +
                $"Data de Nascimento: {DataNascimento}\n" +
                $"Sexo: {Sexo}\n";
        }

       
        

    }
}
