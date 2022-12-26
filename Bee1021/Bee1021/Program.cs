// Bee 1021 - Notas e moedas
using System;
using System.Globalization;

namespace Bee1021_Notas_e_Moedas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* - ler valor flutuante (valor monetario)
             * calcular o menor numero de notas e moedas possiveis
             * mostras a relacao de notas necessárias */

            // variables
            double valorMonetario, notas, moedas;

            // input
            valorMonetario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // code
            Console.WriteLine("NOTAS:");
            notas = (int) (valorMonetario / 100);
            valorMonetario = valorMonetario % 100;
            Console.WriteLine($"{notas} nota(s) de R$ 100.00");
            notas = (int) (valorMonetario / 50);
            valorMonetario = valorMonetario % 50;
            Console.WriteLine($"{notas} nota(s) de R$ 50.00");
            notas = (int) (valorMonetario / 20);
            valorMonetario = valorMonetario % 20;
            Console.WriteLine($"{notas} nota(s) de R$ 20.00");
            notas = (int) (valorMonetario / 10);
            valorMonetario = valorMonetario % 10;
            Console.WriteLine($"{notas} nota(s) de R$ 10.00");
            notas = (int) (valorMonetario / 5);
            valorMonetario = valorMonetario % 5;
            Console.WriteLine($"{notas} nota(s) de R$ 5.00");
            notas = (int) (valorMonetario / 2);
            valorMonetario = valorMonetario % 2;
            Console.WriteLine($"{notas} nota(s) de R$ 2.00");

            // ajustar valor para dividir por numero sem casas decimais e evitar erro no calculo
            valorMonetario = valorMonetario * 100;

            Console.WriteLine("MOEDAS:");
            moedas = (int) (valorMonetario / 100);
            valorMonetario = valorMonetario % 100;
            Console.WriteLine($"{moedas} moeda(s) de R$ 1.00");
            moedas = (int) (valorMonetario / 50);
            valorMonetario = valorMonetario % 50;
            Console.WriteLine($"{moedas} moeda(s) de R$ 0.50");
            moedas = (int) (valorMonetario / 25);
            valorMonetario = valorMonetario % 25;
            Console.WriteLine($"{moedas} moeda(s) de R$ 0.25");
            moedas = (int) (valorMonetario / 10);
            valorMonetario = valorMonetario % 10;
            Console.WriteLine($"{moedas} moeda(s) de R$ 0.10");
            moedas = (int) (valorMonetario / 5);
            valorMonetario = valorMonetario % 5;
            Console.WriteLine($"{moedas} moeda(s) de R$ 0.05");
            moedas = (int) (valorMonetario / 1);
            valorMonetario = valorMonetario % 1;
            Console.WriteLine($"{moedas} moeda(s) de R$ 0.01");
        }
    }
}
