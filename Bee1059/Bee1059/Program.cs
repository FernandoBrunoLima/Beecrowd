using System;

namespace Bee1059
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;

            while (i <= 100)
            {   
                if (i %2 == 0)
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
