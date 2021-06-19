using System;

namespace _9___Cédulas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas
            // são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

            int valor, nota100, nota50, nota20, nota10, nota5, nota2, nota1, resto;

            valor = int.Parse(Console.ReadLine());
            nota100 = valor / 100;
            resto = valor % 100;
            nota50 = resto / 50;
            resto = resto % 50;
            nota20 = resto / 20;
            resto = resto % 20;
            nota10 = resto / 10;
            resto = resto % 10;
            nota5 = resto / 5;
            resto = resto % 5;
            nota2 = resto / 2;
            resto = resto % 2;
            nota1 = resto / 1;
            resto = resto % 1;

            Console.WriteLine(nota100 + " nota(s) de R$ 100,00 " + "\r\n" + nota50 + " nota(s) de R$ 50,00 "+ "\r\n" + nota20 + " nota(s) de R$ 20,00 " + "\r\n" + nota10 + " nota(s) de R$ 10,00 " + "\r\n"
                + nota5 + " nota(s) de R$ 5,00 " + "\r\n" + nota2 + " nota(s) de R$ 2,00 " + "\r\n" + nota1 + " nota(s) de R$ 1,00 ");




        }
    }
}
