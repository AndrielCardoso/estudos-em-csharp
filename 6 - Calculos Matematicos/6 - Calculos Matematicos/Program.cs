using System;
using System.Globalization;

namespace _6___Calculos_Matematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Desenvolver um programa para ler as medidas da base a altura de um retângulo. Em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo
            // com quatro casas decimais.

            double base1, altura, area, perimetro, diagonal;

            // Cálculo de área

            Console.WriteLine("Escreva o tamanho da base: ");
            base1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Escreva o tamanho da altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = base1 * altura;
            Console.WriteLine("A área do retângulo é: " + area.ToString("F4"), CultureInfo.InvariantCulture);

            // Cálculo de perímetro

            perimetro = 2 * base1 + 2 * altura;
            Console.WriteLine("O perímetro do retângulo é: " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);

            // Cálculo do diagonal

            diagonal = Math.Sqrt(Math.Pow(base1, 2.0) + Math.Pow(altura, 2.0));
            Console.WriteLine("O diagonal do retângulo é: " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);

        }
    }
}
