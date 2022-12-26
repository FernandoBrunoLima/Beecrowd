using System;

namespace Bee1097
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, j;
            for (i = 1, j = 7; i <= 9; i += 2, j+=2)
            {

                Console.WriteLine($"I={i} J={j}");
                Console.WriteLine($"I={i} J={j - 1}");
                Console.WriteLine($"I={i} J={j - 2}");
            }
        }
    }
}

