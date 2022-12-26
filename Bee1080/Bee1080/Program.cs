using System;

namespace Bee1080
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maior = -1;
            int posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                int numberN = int.Parse(Console.ReadLine());

                if (numberN > maior)
                {
                    maior = numberN;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}