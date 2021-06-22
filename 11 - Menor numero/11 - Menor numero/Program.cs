using System;

namespace _11___Menor_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o menor dentre os três números lidos. Em caso de empate, mostrar apenas uma vez.
            
            int num1, num2, num3;

            Console.WriteLine("Escreva 3 números para saber qual o menor entre eles: ");
            String[] vet = Console.ReadLine().Split(' ');

            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            num3 = int.Parse(vet[2]);

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("MENOR = " + num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("MENOR = " + num2);
            }
            else
            {
                Console.WriteLine("MENOR = " + num3);
            }
        }
    }
}
