using System;

namespace Bee1172
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] vetorX = new int[10];
            

            for (int i = 0; i < 10; i++)
            {
                vetorX[i] = int.Parse(Console.ReadLine());

                if (vetorX[i] <= 0)
                {
                    vetorX[i] = 1;
                }

                Console.WriteLine($"X[{i}] = {vetorX[i]}");
            }
           
        }
    }
}