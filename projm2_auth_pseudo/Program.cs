using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projm2_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Start:
            String usuario = null, usu_Cad = null, senha = null, sen_Cad = null, tent = null;

            int tentativas = 0;
            Random rnd = new Random();
            int key_dig = 0, check = 1;


            Console.WriteLine("\tXXXXX Company");

            Console.Write("\nCreate username: ");
            usu_Cad = Console.ReadLine(); //abc

            Console.Write("Create password: ");
            sen_Cad = Console.ReadLine(); //123



            while (usuario != usu_Cad)
            {
                Console.Write("\nUsername: ");
                usuario = Console.ReadLine();
                if (usuario != usu_Cad)
                {
                    Console.WriteLine("Username not found. Try again");
                }
                tentativas++;
                if (tentativas == 3)
                {
                    Console.WriteLine("3 unsuccessful tries. Returning to start");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                    goto Start;
                }
            }


            while (tentativas < 3)
            {
                while (senha != sen_Cad)
                {
                    Console.Write("\nPassword: ");
                    senha = Console.ReadLine();
                    if (senha != sen_Cad)
                    {
                        {
                            Console.Write("\nIncorrect Password!\nDo you want to try again? Y/N: ");
                            tent = Console.ReadLine();
                            if (tent == "N")
                            {
                                goto Start;
                            }
                        }
                    }
                    if (senha == sen_Cad)
                    {
                        goto tfa;
                    }

                    tentativas++;
                    if (tentativas == 3)
                    {
                        Console.WriteLine("3 unsuccessful tries. Returning to start");
                        System.Threading.Thread.Sleep(2500);

                        Console.Clear();
                        goto Start;
                    }
                }
            }

        tfa:
            while (key_dig != check)
            {
                int chave1 = rnd.Next(100000, 1000000);
                check = chave1;
                Console.WriteLine(chave1);
                Console.WriteLine("\nType here the code generated");
                key_dig = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("\nAccess granted");
            Console.WriteLine("\nHey there, {0}!", usuario);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}
