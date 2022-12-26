using System;

namespace Bee1177
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int valueT = int.Parse(Console.ReadLine());

            int[] vetorN = new int[1000];

            for (int i = 0; i < vetorN.Length; i++)
            {

                vetorN[i] = i % valueT;


                Console.WriteLine($"N[{i}] = {vetorN[i]}");
            }

        }
    }
}
