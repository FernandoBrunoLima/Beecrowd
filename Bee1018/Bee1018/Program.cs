// Bee 1018 - cédulas
using System;

namespace Bee1018
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variables
            int valorInteiro;
            int qtdNotas;

            // input
            valorInteiro = int.Parse(Console.ReadLine());

            // code
            Console.WriteLine(valorInteiro);
            qtdNotas = valorInteiro / 100;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 100,00");
            valorInteiro = valorInteiro % 100;
            qtdNotas = valorInteiro / 50;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 50,00");
            valorInteiro = valorInteiro % 50;
            qtdNotas = valorInteiro / 20;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 20,00");
            valorInteiro = valorInteiro % 20;
            qtdNotas = valorInteiro / 10;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 10,00");
            valorInteiro = valorInteiro % 10;
            qtdNotas = valorInteiro / 5;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 5,00");
            valorInteiro = valorInteiro % 5;
            qtdNotas = valorInteiro / 2;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 2,00");
            valorInteiro = valorInteiro % 2;
            qtdNotas = valorInteiro / 1;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ 1,00");                       
        }
    }
}
