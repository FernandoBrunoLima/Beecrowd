using System;
using System.Globalization;

namespace Bee1116
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int valueN = int.Parse(Console.ReadLine());

            for (int i = 0; i < valueN; i++)
            {
                string[] valuesXY = Console.ReadLine().Split();
                int valueX = int.Parse(valuesXY[0]);
                int valueY = int.Parse(valuesXY[1]);

                if (valueX < 0 || valueY == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double result = (double) valueX / (double) valueY;
                    Console.WriteLine(result.ToString("0.0#", CultureInfo.InvariantCulture ));
                }
            }
        }
    }
}


