using System;
using System.Globalization;

namespace _10___Exercicio_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma disciplina anual. Em seguida, mostrar a média das notas finais
            // que o aluno obteve no ano juntamente com um texto explicativo. Caso a nota final do aluno seja inferior a 60, mostrar a mensagem "REPROVADO".
            // Todos os valores devem ter uma casa decimal.
            
            double nota1, nota2, notafinal;

            Console.WriteLine("Escreva o valor da primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Escreva o valor da segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notafinal = (nota1 + nota2) / 2;

            if (notafinal >= 6.0)
            {
                Console.WriteLine("NOTA FINAL " + notafinal.ToString("F1"), CultureInfo.InvariantCulture + "\n" + "APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL " + notafinal.ToString("F1"), CultureInfo.InvariantCulture + "\n" + "REPROVADO");
            }

            // Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, 
            // mostre a mensagem "Impossível Calcular", caso haja uma divisão por 0 ou raíz de um número negativo.

            double a, b, c, delta, x1, x2;

            Console.WriteLine("Insira o valor de a, b e c: ");
            String[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = ((b * b) - 4 * a * c);

            if (delta <= 0 || a <= 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("O resultado de x1 é " + x1.ToString("F5") + " O resultado de x2 é " + x2.ToString("F5"));

            }

            

        }
    }
}
