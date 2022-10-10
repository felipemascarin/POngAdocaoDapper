using System;
using Controller;
using Model;

namespace POngAdocaoDapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio();
            static void Inicio()
            {
                try
                {
                    Menu.MenuInicial();
                    Inicio();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("\nAperte 'ENTER' para continuar...");
                    Console.ReadKey();
                    Inicio();
                }
            }
        }
    }
}
