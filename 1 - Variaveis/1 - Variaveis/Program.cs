using System;
using System.Globalization;

namespace _1___Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Andriel";
            byte id = 12;
            byte idade = 23;
            char sexo = 'M';
            int salario = 2000;
            double valor = 18.2570;

            // Para chamar uma variável

            Console.WriteLine(nome);

            // Para retornar um valor com menos números seguidos da vírgula

            Console.WriteLine(valor.ToString("F2"));
            Console.WriteLine(valor.ToString("F4"));

            // Como está em português, o valor retornado é com vírgula, para retornar com ponto é necessário utilizar a biblioteca System.Globalization

            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));

            // Para concatenar valores é necessário utilizar o operador de +

            Console.WriteLine("O usuário " + nome + " ID " + id + " possui " + idade + " anos e é do sexo " + sexo + ". Seu salário atualmente é: R$" + salario);
            Console.ReadLine(); 


        }
    }
}
