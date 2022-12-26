using System;

namespace Bee1179
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, x = 0, y = 0;
            int[] par = new int[5];
            int[] impar = new int[5];

            for (int i = 0; i < 15; i++)
            {
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    par[x] = n;
                    x++;
                }
                else
                {
                    impar[y] = n;
                    y++;
                }

                if (x == par.Length)
                {
                    x = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"par[{j}] = {par[j]}");
                    }

                }
                if (y == impar.Length)
                {
                    y = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"impar[{j}] = {impar[j]}");
                    }
                }

                
            }

            for (int j = 0; j < y; j++)
            {
                Console.WriteLine($"impar[{j}] = {impar[j]}");
            }

            for (int j = 0; j < x; j++)
            {
                Console.WriteLine($"par[{j}] = {par[j]}");
            }
        }


    }
}

