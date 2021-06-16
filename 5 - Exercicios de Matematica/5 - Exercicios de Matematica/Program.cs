using System;

namespace _5___Exercicios_de_Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Desenvolver um programa para ler as medidas de largura e comprimento de um terreno retangular com uma casa decimal, bem como o valor do metro quadrado do terreno
            // com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com duas casas decimais.
            
            double largura, altura, precom2, area, preco;

            Console.WriteLine("Escreva a largura: ");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor total da área é: ");
            area = largura * altura;
            Console.WriteLine(area.ToString("F2"));
            Console.WriteLine("Escreva o preço por metro quadrado: ");
            precom2 = double.Parse(Console.ReadLine());
            preco = area * precom2;
            Console.WriteLine("O preço total da área é: ");
            Console.WriteLine(preco.ToString("F2"));


        }
    }
}
