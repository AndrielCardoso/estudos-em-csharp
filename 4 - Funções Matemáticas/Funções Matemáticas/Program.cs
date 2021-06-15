using System;

namespace Funções_Matemáticas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solving Bhaskara with C#
            
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Escreva o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de c: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            Console.WriteLine("O resultado de delta é "+delta);

            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("O resultado de x1 é: "+x1);
            Console.WriteLine("O resultado de x2 é: " + x2);

            // Solving EHL problem with C#

            double valor_a, valor_b, ehl, multiplicacao1, multiplicacao2, conversao, subtracao, soma1, resultado;

            Console.WriteLine("Quais agentes estão sendo usados? ");
            string agentes = Console.ReadLine();
            Console.WriteLine("Escreva o valor de EHL: ");
            ehl = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de A: ");
            valor_a = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de B: ");
            valor_b = double.Parse(Console.ReadLine());

            multiplicacao1 = ehl * 100;
            Console.WriteLine(multiplicacao1);
            multiplicacao2 = valor_a * 100;
            Console.WriteLine(multiplicacao2);
            conversao = -valor_a;
            Console.WriteLine(conversao);
            subtracao = multiplicacao1 - multiplicacao2;
            soma1 = conversao + valor_b;
            resultado = subtracao / soma1;

            Console.WriteLine("O resultado dos agentes: "+ agentes + "é: " + resultado);



        }
    }
}
