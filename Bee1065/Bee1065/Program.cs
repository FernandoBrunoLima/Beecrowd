using System;

namespace Bee1065
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int valorInteiro;
            int valoresPares = 0;

            for (int i = 0; i < 5; i++)
            {
                valorInteiro = int.Parse(Console.ReadLine());

                if (valorInteiro % 2 == 0)
                {
                    valoresPares++;
                }
            }
            Console.WriteLine($"{valoresPares} valores pares");
        }
    }
}
