// Bhaskara's Formula
using System;
using System.Globalization;

namespace Bee1036
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variables
            double numA, numB, numC, delta, result1, result2;
            string[] floatNumbersList;

            // input
            floatNumbersList = Console.ReadLine().Split(' ');

            numA = double.Parse(floatNumbersList[0], CultureInfo.InvariantCulture);
            numB = double.Parse(floatNumbersList[1], CultureInfo.InvariantCulture);
            numC = double.Parse(floatNumbersList[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(numB, 2) - (4 * numA * numC);

            if (numA == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                result1 = ((-numB + Math.Sqrt(delta))) / (2 * numA);
                result2 = ((-numB - Math.Sqrt(delta))) / (2 * numA);

                Console.WriteLine($"R1 = {result1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {result2.ToString("F5", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
