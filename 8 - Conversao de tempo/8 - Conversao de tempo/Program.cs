using System;

namespace _8___Conversao_de_tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos
            
            double horas, minutos, segundos, resto, N;

            N = double.Parse(Console.ReadLine());
            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(N + " em horas é: " + horas + ":" + minutos + ":" + segundos);

            // Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

            int N2, ano, mes, dia, resto_ano;

            Console.WriteLine("Escreva quantos dias deseja consultar: ");
            N2 = int.Parse(Console.ReadLine());
            ano = N2 / 365;
            resto_ano = N2 % 365;
            mes = resto_ano / 30;
            dia = resto_ano % 30;

            Console.WriteLine("Você já viveu " + ano + " ano(s), " + mes + " mês(es), " + dia + " e dia(s).");

        }
    }
}
