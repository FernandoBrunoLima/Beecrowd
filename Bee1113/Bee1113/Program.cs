using System;

namespace Bee1113
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valuesXY = Console.ReadLine().Split();
            int valueX = int.Parse(valuesXY[0]);
            int valueY = int.Parse(valuesXY[1]);

            while (valueX != valueY)
            {
                if (valueX < valueY)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }

                valuesXY = Console.ReadLine().Split();
                valueX = int.Parse(valuesXY[0]);
                valueY = int.Parse(valuesXY[1]);
            }
        }
    }
}
