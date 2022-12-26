using System;

namespace Bee1074
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberN; i++)
            {
                int numberX = int.Parse(Console.ReadLine());

                if (numberX > 0)
                {
                    if (numberX % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else if (numberX < 0)
                {
                    if (numberX % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
