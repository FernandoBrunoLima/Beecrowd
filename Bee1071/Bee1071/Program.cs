using System;

namespace Bee1071
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numX, numY, soma, numeroImpares;

            numX = int.Parse(Console.ReadLine());
            numY = int.Parse(Console.ReadLine());

            if (numX > numY)
            {
                int aux = numX;
                numX = numY;
                numY = aux;
            }

            soma = 0;
            //numeroImpares = 0;

            for (int i = numX+1; i < numY; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                    
                }
            }

            Console.WriteLine(soma);
        }
    }
}
