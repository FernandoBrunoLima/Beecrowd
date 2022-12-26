using System;
using System.Globalization;

namespace Bee1051_ImpostoDeRenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double impostoRenda = 0.00;
            double impostoDevido = 0.00;

            if (salario >= 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                if (salario >= 2000.01 && salario <= 3000.00)
                {
                    
                    impostoDevido = (salario - 2000) * 0.08;
                }
                else if (salario >= 3000.01 && salario <= 4500.00)
                {
                    impostoRenda = 0.18;
                    impostoDevido = ((salario - 3000) * 0.18) + (1000.00 * 0.08);
                }
                else if (salario > 4500.00)
                {
                    impostoDevido = ((salario - 4500.00) * 0.28) + (1500.00 * 0.18) + (1000 * 0.08);
                }
                Console.WriteLine($"R$ {impostoDevido.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
