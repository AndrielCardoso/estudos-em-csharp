using System;

namespace _15__Crescente_e_Decrescente
{
    class Program
    {
        static void Main(string[] args)
        {

            // Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma mensagem que indique se estes valores
            // foram digitados em ordem crescente ou decrescente

            int x, y;

            String[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
          
                }else
                {
                    Console.WriteLine("Decrescente");
                }

                vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

        }
    }
}
