using System;
using System.Globalization;

namespace Bee1118
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int calculo = 1;
            double nota1, nota2;

            do
            {
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (nota1 < 0.00 || nota1 > 10.00)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (nota2 < 0.00 || nota2 > 10.00)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double media = (nota1 + nota2) / 2;
                Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");

                Console.WriteLine("novo calculo (1-sim 2-nao)");

                calculo = int.Parse(Console.ReadLine());

                while (calculo != 1 && calculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    calculo = int.Parse(Console.ReadLine());
                }
            }
            while (calculo == 1);

        }
    }
}