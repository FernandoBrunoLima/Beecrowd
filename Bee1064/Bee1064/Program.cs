using System;
using System.Globalization;

namespace Bee1064
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double valor;
            double qtdPositivos = 0;
            double somaValoresPositivos = 0;
            double media;

            
            for (int i = 0; i < 6; i++)
            {
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (valor > 0)
                {
                    qtdPositivos++;
                    somaValoresPositivos = somaValoresPositivos + valor;
                }
            }

            media = somaValoresPositivos / qtdPositivos;

            Console.WriteLine($"{qtdPositivos} valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
