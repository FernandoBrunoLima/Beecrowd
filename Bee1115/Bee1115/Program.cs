using System;

namespace Bee1115
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] coordinatesXY = Console.ReadLine().Split();
            int coordinateX = int.Parse(coordinatesXY[0]);
            int coordinateY = int.Parse(coordinatesXY[1]);

            while (coordinateX != 0 && coordinateY != 0)
            {
                if (coordinateX > 0 && coordinateY > 0)
                {
                    Console.WriteLine("primeiro");
                }
                if (coordinateX < 0 && coordinateY > 0)
                {
                    Console.WriteLine("segundo");
                }
                if (coordinateX < 0 && coordinateY < 0)
                {
                    Console.WriteLine("terceiro");
                }
                if (coordinateX > 0 && coordinateY < 0)
                {
                    Console.WriteLine("quarto");
                }

                coordinatesXY = Console.ReadLine().Split();
                coordinateX = int.Parse(coordinatesXY[0]);
                coordinateY = int.Parse(coordinatesXY[1]);
            }
        }
    }
}