using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;
using Model;

namespace Builder
{
    public class AdotanteBuilder : iAdotanteBuilder
    {
        public Adotante adotante;

        public void Reset()
        {
            adotante = new Adotante();
            Console.Clear();
        }
        public void MakeCPF()
        {
            Console.Write("CPF (Apenas 11 números): ");
            adotante.CPF = Console.ReadLine();
        }
        public void MakeNomeAdotante()
        {
            Console.Write("Nome: ");
            adotante.NomeAdotante = Console.ReadLine();
        }
        public void MakeDataNascimento()
        {
            Console.Write("Data de Nascimento (Digite as barras dd/MM/yyyy): ");
            adotante.DataNascimento = DateTime.Parse(Console.ReadLine());
        }
        public void MakeSexo()
        {
            Console.Write("Sexo (M / F): ");
            adotante.Sexo = char.Parse(Console.ReadLine().ToUpper());
        }

        public Adotante GetResult() { return adotante; }
    }
}
