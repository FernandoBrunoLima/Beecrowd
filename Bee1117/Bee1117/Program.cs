using System;
using System.Globalization;

namespace Bee1117
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int qtdNotas = 0;
            double media = 0.0;

            while (qtdNotas < 2)
            {
                double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (notas >= 0.00 && notas <= 10.00)
                {
                    qtdNotas++;
                    media += notas;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            media = media / 2;
            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }

    }
}
