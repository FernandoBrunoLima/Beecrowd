using System;

namespace Bee1175
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] vetorN = new int[20];

            for (int i = 0; i < 20; i++)
            {
                vetorN[i] = int.Parse(Console.ReadLine());                            
            }

            Array.Reverse(vetorN);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"N[{i}] = {vetorN[i]}");
            }

        }
    }
}