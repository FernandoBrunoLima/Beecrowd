using System;
using System.ComponentModel;

namespace Beecrowd1044_Multiplos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valoresInteiros = Console.ReadLine().Split(' ');
            int valorA = int.Parse(valoresInteiros[0]);
            int valorB = int.Parse(valoresInteiros[1]);

            if (valorA < valorB)
            {
                int temp = valorA;
                valorA = valorB;
                valorB = temp;
            }

            if (valorA % valorB == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
