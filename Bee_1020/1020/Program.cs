// Bee 1020
using System;

namespace Bee1020
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            // variables
            int idadeEmDias, anos, meses, dias, diasRestantes;

            // input
            idadeEmDias = int.Parse(Console.ReadLine());

            // code

            // 1 ano tem 365 dias
            anos = idadeEmDias / 365;
            diasRestantes = idadeEmDias % 365;

            // 1 mes tem 30 dias
            meses= diasRestantes / 30;
            dias = diasRestantes% 30;

            // output
            Console.WriteLine($"{anos} anos(s)\n{meses} mes(es)\n{dias} dia(s)");
        }
    }
}
