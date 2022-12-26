using System;

namespace Bee1065
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int valorInteiro;
            int valoresPares = 0;
            int valoresImpares = 0;
            int valoresPositivos = 0;
            int valoresNegativos = 0;

            for (int i = 0; i < 5; i++)
            {
                valorInteiro = int.Parse(Console.ReadLine());

                if (valorInteiro % 2 == 0)
                {
                    valoresPares++;
                }
                else if (valorInteiro % 2 != 0)
                {
                    valoresImpares++;
                }

                if (valorInteiro > 0)
                {
                    valoresPositivos++;
                }
                else if (valorInteiro < 0)
                {
                    valoresNegativos++;
                }
            }
            Console.WriteLine($"{valoresPares} valor(es) par(es)");
            Console.WriteLine($"{valoresImpares} valor(es) impar(es)");
            Console.WriteLine($"{valoresPositivos} valor(es) positivo(s)");
            Console.WriteLine($"{valoresNegativos} valor(es) negativo(s)");
        }
    }
}
