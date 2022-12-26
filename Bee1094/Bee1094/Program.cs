using System;
using System.Globalization;

namespace Bee1094
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int cobaias = 0, coelhos = 0, ratos = 0, sapos = 0;

            for (int i = 0; i < numberN; i++)
            {
                string[] quantiaETipo = Console.ReadLine().Split(' ');
                int quantia = int.Parse(quantiaETipo[0]);
                char tipo = char.Parse(quantiaETipo[1]);

                if (tipo == 'C')
                {
                    coelhos += quantia;
                }
                else if (tipo == 'R')
                {
                    ratos += quantia;
                }
                else if (tipo == 'S')
                {
                    sapos += quantia;
                }

                /*
                switch (tipo)
                {
                    case "C":
                        coelhos += quantia;
                        break;
                    case "R":
                        ratos += quantia;
                        break;
                    case "S":
                        sapos += quantia;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }*/
                cobaias += quantia;
                                
            }

            double percentualCoelhos = (double)coelhos / cobaias * 100.00;
            double percentualRatos = (double)ratos / cobaias * 100.00;
            double percentualSapos = (double)sapos / cobaias * 100.00;

            Console.WriteLine($"Total: {cobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {percentualCoelhos.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {percentualRatos.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {percentualSapos.ToString("F2", CultureInfo.InvariantCulture)} %");

        }
    }
}