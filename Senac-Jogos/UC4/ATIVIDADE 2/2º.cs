using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<String> listArmas = new List<string>();
            //Atribuição Sttatic
            listArmas.Add("Pistola");
            listArmas.Add("Espingarda");
            listArmas.Add("Bastão");
            listArmas.Add("Laser");
            listArmas.Add("Plasma");

            int op = new int();
            do
            {
                Console.WriteLine("\nSelecione a arma:\n");
                Console.WriteLine("1--Pistola\n");
                Console.WriteLine("2--Espingarda\n");
                Console.WriteLine("3--Bastão\n");
                Console.WriteLine("4--Laser\n");
                Console.WriteLine("5--Plasma\n");
                Console.WriteLine("9--Sair");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1 :
                        Console.WriteLine(listArmas[0]);
                        break;
                    case 2:
                        Console.WriteLine(listArmas[1]);
                        break;
                    case 3:
                        Console.WriteLine(listArmas[2]);
                        break;
                    case 4:
                        Console.WriteLine(listArmas[3]);
                        break;
                    case 5:
                        Console.WriteLine(listArmas[4]);
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
                Console.WriteLine("\n");
            } while (op!=9); 
        }
    }

}