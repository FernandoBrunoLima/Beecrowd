using System;
using System.Globalization;

namespace Bee1174
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] vetorX = new double[100];


            for (int i = 0; i < 100; i++)
            {
                vetorX[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (vetorX[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {vetorX[i].ToString("F1", CultureInfo.InvariantCulture)}");
                }
                
            }

        }
    }
}