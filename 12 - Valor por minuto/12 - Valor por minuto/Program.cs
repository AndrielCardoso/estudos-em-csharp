using System;
using System.Globalization;

namespace _12___Valor_por_minuto
{
    class Program
    {
        static void Main(string[] args)
        {

            // Uma operadora de telefonia cobra R$50,00 por um plano básico que dá direito a 100 minutos de telefone. Cada minuto que exceder a franquia de 100 minutos custa R$2,00.
            // Faça um programa para ler a quantidade de minutos que uma pessoa consumiu, e mostrar o valor a ser pago.
            
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            
            if (minutos > 100)
            {
                conta += + (minutos - 100) * 2;
                
            }
            else
            {

            }

            Console.WriteLine("Valor a pagar: R$" + conta.ToString("F2"), CultureInfo.InvariantCulture);


        }
    }
}
