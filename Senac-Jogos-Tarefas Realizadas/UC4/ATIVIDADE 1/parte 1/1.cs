using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int vidaJonh = 100;
            int danoArma ;
            int qtTiros ;

            danoArma=getDano();
            qtTiros = getTiros();
            vidaJonh = setLife(danoArma, qtTiros, vidaJonh);
            Console.WriteLine("Vida atual = "+vidaJonh);

        }


        private static int getDano()
        {
            int buffer = new int();
            Console.WriteLine("Informe a quantidade de dano da Arma:");
            buffer = Convert.ToInt32(Console.ReadLine());
            return buffer;
        }
        private static int getTiros()
        {
            int buffer = new int();
            Console.WriteLine("Informe a quantidade de tiros recebidos:");
            buffer = Convert.ToInt32(Console.ReadLine());
            return buffer;
        }
        private static int setLife(int dano,int tiros,int life)
        {
            return life - (dano * tiros);
        }
    }

}