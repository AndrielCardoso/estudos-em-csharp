using System;

namespace _17___For
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, soma;

            n = int.Parse(Console.ReadLine()); 

            soma = 0;

            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
                

            }

            Console.WriteLine("O resultado da soma da sequência é: " + soma);
        }
    }
}
