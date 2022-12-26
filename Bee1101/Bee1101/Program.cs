using System;

namespace Bee1101
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valuesMN = Console.ReadLine().Split();
            int valueM = int.Parse(valuesMN[0]);
            int valueN = int.Parse(valuesMN[1]);

            while (valueM > 0 && valueN > 0)
            {
                if (valueM > valueN)
                {
                    int aux = valueM;
                    valueM = valueN;
                    valueN = aux;
                }

                int soma = 0;
                for (int i = valueM; i <= valueN; i++)
                {
                    soma += i;
                    Console.Write($"{i} ");

                }
                Console.WriteLine($"Sum={soma}");

                valuesMN = Console.ReadLine().Split();
                valueM = int.Parse(valuesMN[0]);
                valueN = int.Parse(valuesMN[1]);
            }
        }
    }
}
