using System;
using Builder.Interfaces;
using Model;

namespace Builder
{
    public class AdocaoBuilder : iAdocaoBuilder
    {
        public Adocao adocao;

        public void Reset()
        {
            adocao = new Adocao();
            Console.Clear();
        }
        public void MakeChip()
        {
            Console.WriteLine("Digite o número do CHIP do animal a ser adotado: ");
            adocao.Chip = Console.ReadLine();
        }
        public void MakeCPF()
        {
            Console.WriteLine("Digite o CPF do adotante: ");
            adocao.CPF = Console.ReadLine();
        }
        public void MakeDataAdocao()
        {
            adocao.DataAdocao = System.DateTime.Now;
        }

        public Adocao GetResult() { return adocao; }
    }
}
