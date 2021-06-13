using System;

namespace _2___Processamento_de_dados_e_Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            // Somando duas variáveis int
            int x, y;

            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            // Somando uma variável int e uma double

            int x2;
            double y2;

            x2 = 5;
            y2 = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            // Calcular a área de um trapézio : area = (b+B)/2*h

            double b, B, h, area;

            b = 6.0;    // Caso seja double, convém indicar na variável o .0 e para float colocar "f" no final, p.ex: 6f
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2 * h;
            Console.WriteLine(area);

            // Realizar conta através de int e resultado retorna float (Realizar CASTING)

            int a, b2;
            double resultado;

            a = 5;
            b2 = 2;

            resultado = (double) a / b2;

            Console.WriteLine(resultado);

        }
    }
}
