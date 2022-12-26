using System;
using System.Security.Cryptography.X509Certificates;

namespace Bee1072
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numbersIn = 0, numbersOut = 0;

            for (int i = 0; i < numberN; i++)
            {
                int numbersX = int.Parse(Console.ReadLine()); ;
                if( numbersX >= 10 && numbersX <= 20)
                {
                    numbersIn += 1;
                } else
                {
                    numbersOut += 1;
                }
            }

            Console.WriteLine($"{numbersIn} in");
            Console.WriteLine($"{numbersOut} out");
        }
    }
}
