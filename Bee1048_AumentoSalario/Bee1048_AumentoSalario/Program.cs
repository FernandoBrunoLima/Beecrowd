using System;
using System.Globalization;

namespace Bee1048
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario, percentualReajuste, reajusteGanho, novoSalario;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            percentualReajuste = 0.00;
            
            if (salario >= 400.01 && salario <= 800.00)
            {
                // percentual de reajuste (12%)
                percentualReajuste = 0.12;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                // percentual de reajuste (10%)
                percentualReajuste = 0.10;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                // percentual de reajuste (0.07%)
                percentualReajuste = 0.07;
            }
            else if (salario > 2000.00)
            {
                // percentual de reajuste (0.04%)
                percentualReajuste = 0.04;
            } else
            {
                percentualReajuste = 0.15;
            }

            reajusteGanho = salario * percentualReajuste;
            novoSalario = salario + reajusteGanho;

            Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Reajuste ganho: {reajusteGanho.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Em percentual: {(percentualReajuste*100).ToString("F0", CultureInfo.InvariantCulture)} %");

        }
    }
}
