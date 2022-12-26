using System;
using System.Globalization;

namespace Bee1060
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double valor; 
            double qtdPositivos;

            for (int i = 0; i < 6; i++)
            {
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (valor > 0)
                {   
                    qtdPositivos++;
                }
            }

            Console.WriteLine($"{qtdPositivos} valores positivos");

        }
    }
}
