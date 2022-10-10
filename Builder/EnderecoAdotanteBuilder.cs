using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;
using Model;

namespace Builder
{
    public class EnderecoAdotanteBuilder : iEnderecoAdotanteBuilder
    {
        public EnderecoAdotante enderecoadotante;

        public void Reset()
        {
            enderecoadotante = new EnderecoAdotante();
            Console.Clear();
        }
        public void MakeTipoLogradouro()
        {
            Console.Write("Tipo Logradouro (Rua, Avenida...): ");
            enderecoadotante.TipoLogradouro = Console.ReadLine();
        }
        public void MakeNomeLogradouro()
        {
            Console.Write("Nome do logradouro: ");
            enderecoadotante.NomeLogradouro = Console.ReadLine();
        }
        public void MakeBairro()
        {
            Console.Write("Bairro:");
            enderecoadotante.Bairro = Console.ReadLine();
        }
        public void MakeCidade()
        {
            Console.Write("Cidade:");
            enderecoadotante.Cidade = Console.ReadLine();
        }
        public void MakeEstado() 
        {
            Console.Write("Estado:");
            enderecoadotante.Estado = Console.ReadLine();
        }
        public void MakeCEP()
        {
            Console.Write("CEP:");
            enderecoadotante.CEP = Console.ReadLine();
        }

        public EnderecoAdotante GetResult() { return enderecoadotante; }
    }
}
