using System.Globalization;

namespace Bee1008_Salario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Number, horasTrabalhadas;
            double valorPorHora, Salary;

            Number = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salary = horasTrabalhadas*valorPorHora;

            Console.WriteLine($"NUMBER = {Number}");
            Console.WriteLine($"SALARY = U$ {Salary.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}