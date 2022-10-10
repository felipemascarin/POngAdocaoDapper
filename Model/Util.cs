using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Util
    {
        public static void Pausa()
        {
            Console.WriteLine("\nAperte 'ENTER' para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        //public static bool PausaMensagem()
        //{
        //    bool repetirdo;
        //    do
        //    {
        //        Console.WriteLine("\nPressione S para informar novamente ou C para cancelar:");
        //        ConsoleKeyInfo op = Console.ReadKey(true);
        //        if (op.Key == ConsoleKey.S)
        //        {
        //            Console.Clear();
        //            return false;
        //        }
        //        else
        //        {
        //            if (op.Key == ConsoleKey.C)
        //            {
        //                Console.Clear();
        //                return true;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Escolha uma opção válida!");
        //                repetirdo = true;
        //            }
        //        }
        //    } while (repetirdo == true);
        //    return true;
        //}

        public static string ValidarEntrada(string entrada)
        {
            string[] vetornumeros = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //Para entrada de tecla
            bool encontrado;

            switch (entrada)
            {
                case "menu":

                    #region menu

                    do
                    {
                        try
                        {
                            char[] vetortecla;
                            Console.CursorVisible = false;
                            ConsoleKeyInfo op = Console.ReadKey(true);
                            vetortecla = op.Key.ToString().ToCharArray();

                            if (vetortecla[0] == 'N')
                            {
                                if (vetornumeros.Contains(vetortecla[6].ToString()) == true)
                                {
                                    return vetortecla[6].ToString();
                                }
                                else
                                {
                                    encontrado = false;
                                }
                            }
                            else
                            {
                                if (vetortecla[0] == 'D')
                                {
                                    if (vetornumeros.Contains(vetortecla[1].ToString()) == true)
                                    {
                                        return vetortecla[1].ToString();
                                    }
                                    else
                                    {
                                        encontrado = false;
                                    }
                                }
                                else
                                {
                                    encontrado = false;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            encontrado = false;
                        }
                    } while (encontrado == false);

                    return null;

                #endregion

                default:
                    return null;
            }
        }
    }
}
