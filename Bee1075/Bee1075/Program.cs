using System;

namespace Bee1075
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % numberN == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}