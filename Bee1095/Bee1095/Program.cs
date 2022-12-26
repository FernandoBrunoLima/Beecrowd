using System;

namespace Bee1095
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, j;
            for (i = 1, j = 60; j >= 0; j -= 5, i += 3)
            {
                Console.WriteLine($"I={i} J={j}");
            }
            
        }
    }
}