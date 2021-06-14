using System;
using System.Globalization;

namespace Entrada_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int x;
            double y;
            char z;

            a = Console.ReadLine();
            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z = char.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(x);
            Console.WriteLine(y.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(z);

            // Para informar vários valores em uma única linha

            string[] vet = Console.ReadLine().Split(' ');

            a = vet[0];
            x = int.Parse(vet[1]);
            y = double.Parse(vet[2], CultureInfo.InvariantCulture);
            z = char.Parse(vet[3]);

            Console.WriteLine(a);
            Console.WriteLine(x);
            Console.WriteLine(y.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(z);




        }
    }
}
