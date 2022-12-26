using System;

namespace Bee1173
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            int[] vetorN = new int[10];

            if (value <= 50) { 

                for (int i = 0; i < 10; i++)
                {
                    if (i == 0)
                    {
                        vetorN[i] = value;
                    }
                    else
                    {
                        value = value * 2;
                    }

                    Console.WriteLine($"N[{i}] = {value}");
                }
            }
        }
    }
}
