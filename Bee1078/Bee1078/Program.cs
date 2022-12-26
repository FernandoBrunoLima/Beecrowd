using System;

namespace Bee1078
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = i * numberN;

                Console.WriteLine($"{i} x {numberN} = {result}");
            }
        }
    }
}