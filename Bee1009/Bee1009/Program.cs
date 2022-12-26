using System.Globalization;

namespace Bee1009
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string nomeFuncionario = Console.ReadLine();
            double salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Total = salarioFuncionario + totalDeVendas * 0.15;

            Console.WriteLine(nomeFuncionario);
            Console.WriteLine($"TOTAL = R$ {Total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
