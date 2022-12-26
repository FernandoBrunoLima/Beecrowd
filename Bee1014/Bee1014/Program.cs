//Bee1014
using System;
using System.Globalization;

namespace Bee1014
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variables
            int X;
            double Y, kmPorLitro;

            // Input
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Code

            kmPorLitro = X / Y;

            // Output

            Console.WriteLine($"{kmPorLitro.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}