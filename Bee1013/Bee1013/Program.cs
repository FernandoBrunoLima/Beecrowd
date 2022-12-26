// Bee 1013
using System;

namespace Bee1013
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int A, B, C, MaiorAB, MaiorABC;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            MaiorAB = (A + B + Math.Abs(A - B)) / 2;

            MaiorABC = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine($"{MaiorABC} eh o maior");

        }
    }
}
