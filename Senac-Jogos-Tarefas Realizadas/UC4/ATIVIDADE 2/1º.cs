using System;
using System.Collections;
using System.Collections.Generic;




namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Stack<String> listAbd = new Stack<string>();
            
            listAbd.Push("Mário disse ter visto uma abdução no início da semana passada ao lado da igreja.");
            listAbd.Push("José disse que viu uma pessoa ser abduzida no fundo da escola no final da semana passada.");
            listAbd.Push("Kauê disse que um alien abduziu uma criança na praça no último domingo.");
            listAbd.Push("Davi ouviu falarem de uma abdução próxima à prefeitura na segunda passada.");
            listAbd.Push("Leon relatou uma ocorrência próxima ao bar hoje pela manhã.");

            Console.WriteLine("Pistas das abduções:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n"+listAbd.Pop());
            }
            
            
            
            
            /*Justificativa do Uso da estrutura de Dados "Pilha" :
                Ao utilizarmos essa estrutura de dados podemos retirar na ordem inversa a de inserção
                e sabendo que os dados tendem a ser informados do mais velho para o mais novo e o usuario
                precisa recebe-lo em ordem inversa a inserida.
                */
        }
    }

}