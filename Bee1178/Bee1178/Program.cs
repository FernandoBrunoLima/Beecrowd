using System;
using System.Globalization;

namespace Bee1178
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal valueX = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal[] vetorN = new decimal[100];
            int i = 0;

            vetorN[0] = valueX;

            Console.WriteLine($"N[{i}] = {Math.Round(vetorN[0], 4, MidpointRounding.ToEven)}".Replace(",", "."));
            for (i = 1; i < 100; i++)
            {
                vetorN[i] = vetorN[i - 1] / 2;
                Console.WriteLine($"N[{i}] = {Math.Round(vetorN[i], 4, MidpointRounding.ToEven)}".Replace(",", "."));
            }



        }
    }
}