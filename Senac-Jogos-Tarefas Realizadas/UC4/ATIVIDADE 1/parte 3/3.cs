using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int vlMax=0;
            int vlMin=2147483646;
            int vlAtual;
            String nomeMax=null;
            String nomeMin= null;
            String nomeAtual = null;
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o nome do "+(i+1)+"º jogador:");
                nomeAtual = Console.ReadLine();
                Console.WriteLine("Informe a Pontuação:");
                vlAtual = Convert.ToInt32(Console.ReadLine());
                while (vlAtual<0)
                {
                    Console.WriteLine("Valor Informado Incorreto! A pontuação não pode ser negativa!\nInfome novamente a pontução do jogador:");
                    vlAtual = Convert.ToInt32(Console.ReadLine()); 
                }
                    if (vlAtual >= vlMax)
                    {
                        vlMax = vlAtual;
                        nomeMax = nomeAtual;
                    }
                    else if(vlMin >= vlAtual)
                    {
                        vlMin = vlAtual;
                        nomeMin = nomeAtual;
                    }
            }
            Console.Write("Maior pontuação:"+nomeMax+" Pontuação:"+vlMax);
            Console.Write("\nMenor pontuação:"+nomeMin+" Pontuação:"+vlMin);

        }

    }

}