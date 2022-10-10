using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;
using Model;

namespace Builder
{
    public class ContatoAdotanteBuilder : iContatoAdotanteBuilder
    {
        public ContatoAdotante contatoadotante;

        public void Reset()
        {
            contatoadotante = new ContatoAdotante();
            Console.Clear();
        }
        
        public void MakeNumero()
        {
            Console.Write("Numero de Contato: ");
            contatoadotante.Numero = Console.ReadLine();
        }
        public void MakeTipo()
        {
            Console.Write("Tipo de Contato (Celular, Telefone fixo): ");
            contatoadotante.Tipo = Console.ReadLine();
        }

        public ContatoAdotante GetResult() { return contatoadotante; }
    }
}
