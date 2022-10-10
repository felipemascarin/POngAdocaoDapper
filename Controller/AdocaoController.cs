using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;
using Builder.Director;
using Model;
using Repository.Interfaces;
using Services;

namespace Controller
{
    public class AdocaoController
    {
        public static bool Add(Adocao adocao)
        {
            return new AdocaoService().Add(adocao);
        }

        public static List<Adocao> GetAll()
        {
            return new AdocaoService().GetAll();
        }

        public static void CadastrarAdocao()
        {
            AdocaoBuilder adocaobuilder = new();
            DirectorAdocaoProduct diretor = new(adocaobuilder);
            diretor.BuildAdocao();
            Adocao adocao = adocaobuilder.GetResult();
            Add(adocao);
        }

        public static void ExibirAdocao()
        {
            Console.WriteLine("Digite o CPF do adotante: ");
            string cpf = Console.ReadLine();

            List<Adocao> adocoes = GetAll();

            if (adocoes.Count > 0)
            {
                foreach (var item in adocoes)
                {
                    if (cpf == item.CPF)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                Util.Pausa();
            }
            else
            {
                Console.WriteLine("Nenhuma adoção encontrada para esse CPF!");
                Util.Pausa();
            }

        }

    }
}
