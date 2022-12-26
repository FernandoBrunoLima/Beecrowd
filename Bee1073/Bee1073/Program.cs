using System;

namespace Bee1073
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberN; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}^2 = {i*i}");
                }
            }
        }
    }
}
