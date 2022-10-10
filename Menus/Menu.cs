using System;
using Model;

namespace Controller
{
    public class Menu
    {

        public static void MenuInicial()
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de adoção de animais (ONG Adoção)\n");
                Console.WriteLine("\nInforme a Opção Desejada:\n");
                Console.WriteLine(" 1 - Cadastrar Animal\n");
                Console.WriteLine(" 2 - Cadastrar Adotante\n");
                Console.WriteLine(" 3 - Cadastrar Adoção\n");
                Console.WriteLine(" 4 - Adoções realizadas\n");
                Console.WriteLine("\n 0 - Encerrar\n");
                opc = int.Parse(Util.ValidarEntrada("menu"));
                Console.Clear();
                switch (opc)
                {
                    case 0:

                        Console.WriteLine("Encerrado");
                        Environment.Exit(0);

                        break;

                    case 1:

                        AnimalController.CadastrarAnimal();

                        break;

                    case 2:

                        AdotanteController.CadastrarAdotante();

                        break;

                    case 3:

                        AdocaoController.CadastrarAdocao();

                        break;

                    case 4:

                        AdocaoController.ExibirAdocao();

                        break;

                }

            } while (true);

        }

    }
}
