using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NPI_Calculator
{
    class Program
    {
        static void Help()
        {
            Console.WriteLine("Calculatrice à notation inversée \n");
            Console.WriteLine("Saisissez une expression et appuyez sur Entrée pour lancer le calcul. \n");
            Console.WriteLine("Les opérateurs supportés sont: '+', '-', '*', '/' \n\n");
            Console.WriteLine("Commandes disponibles: \n");
            Console.WriteLine("'help': description et commandes");
            Console.WriteLine("'clear': effacer le contenu de la console");
            Console.WriteLine("'stop': quitter l'application \n");
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
            Clear();

        }

        static void Clear()
        {
            Console.Clear();
        }

        static void Stop()
        {
            System.Environment.Exit(1);
        }

        static int Calcul(string line)
        {
            string[] tab = line.Split(" ");
            Stack<int> s = new Stack<int>();

            if(Is_valid(line) != 1)
            {
                Console.WriteLine("Expression incorrecte.");
                Console.Write("Code returned: ");
                return 0;
            }
            else
            {
                foreach (string elt in tab)
                {
                    int n1;
                    int n2;
                    switch (elt)
                    {
                        case ("+"):
                            s.Push(s.Pop() + s.Pop());
                            break;
                        case ("*"):
                            s.Push(s.Pop() * s.Pop());
                            break;
                        case ("-"):
                            n2 = s.Pop();
                            n1 = s.Pop();
                            s.Push(n1 - n2);
                            break;
                        case ("/"):
                            n2 = s.Pop();
                            n1 = s.Pop();
                            s.Push(n1 / n2);
                            break;
                        default:
                            s.Push(Int32.Parse(elt));
                            break;

                    }


                }
                //if (s.Count > 1)
                //{
                //    Console.WriteLine("Expression invalide.");
                //}

                return s.Pop();
            }


        }

        static int Is_valid(string line)
        {
            string[] operateurs = { "+", "-", "*", "/" };
            string[] tab = line.Split(" ");
            int op = 0;
            int i = 0;
            foreach (string elt in tab)
            {
                if (operateurs.Contains(elt))
                {
                    op++;
                }
            }
            int numbers = tab.Length - op;
            int diff = numbers - op;

            if (operateurs.Contains(tab[tab.Length - 1]))
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            if (diff != 1 || tab.Length == 1)
            {
                return 0;
            }
            else if (i == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        static void Main(string[] args)
        {
            int x = 0;
            while (x != 1)
            {
                Console.Write("RPN Calculator > ");
                string line = Console.ReadLine();

                if (line == "help")
                {
                    Help();
                }
                else if (line == "clear")
                {
                    Clear();
                }
                else if (line == "stop")
                {
                    Stop();
                }
                else
                {
                    int res = Calcul(line);
                    Console.WriteLine(res);

                }

              
            }
        }

    }
    
}
