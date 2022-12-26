using System;
using System.Globalization;

namespace Bee1041
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String[] coordenadasXY = Console.ReadLine().Split(' ');
            double numX = double.Parse(coordenadasXY[0], CultureInfo.InvariantCulture);
            double numY = double.Parse(coordenadasXY[1], CultureInfo.InvariantCulture);

            if (numX > 0.0 && numY > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (numX < 0.0 && numY > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (numX < 0.0 && numY < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (numX > 0.0 && numY < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (numX == 0.0 && numY == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (numX == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (numY == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
