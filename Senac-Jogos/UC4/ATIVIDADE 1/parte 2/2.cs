using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int vidaJonh = 100;
            int danoArma;
            int qtTiros;

            danoArma=GetDano();
            qtTiros = GetTiros();
            vidaJonh = SetLife(danoArma, qtTiros, vidaJonh);
            Onlive(vidaJonh);

        }


        private static int GetDano()
        {
            int buffer = new int();
            Console.WriteLine("Informe a quantidade de dano da Arma:");
            buffer = Convert.ToInt32(Console.ReadLine());
            return buffer;
        }
        private static int GetTiros()
        {
            int buffer = new int();
            Console.WriteLine("Informe a quantidade de tiros recebidos:");
            buffer = Convert.ToInt32(Console.ReadLine());
            return buffer;
        }
        private static int SetLife(int dano,int tiros,int life)
        {

            return life = life - (dano * tiros);
        }

        private static void Onlive(int life)
        {
            if (life <= 0)
            {
                Console.WriteLine("O personagem Morreu, GAME OVER!");
            }
            else
            {
                Console.WriteLine("O personagem continua vivo."+"Vida atual="+life);
            }
        }
    }

}