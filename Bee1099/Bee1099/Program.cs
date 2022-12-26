using System;

namespace Bee1099
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberN; i++)
            {
                string[] numbersXY = Console.ReadLine().Split();
                int numberX = int.Parse(numbersXY[0]);
                int numberY = int.Parse(numbersXY[1]);

                int somaImpares = 0;

                if (numberX > numberY)
                {
                    int aux = numberX;
                    numberX = numberY;
                    numberY = aux;

                }

                for (int j = numberX + 1; j < numberY; j++)
                {

                    if (j % 2 != 0)
                    {
                        somaImpares = somaImpares + j;
                    }

                }
                Console.WriteLine(somaImpares);
            }
        }
    }
}
