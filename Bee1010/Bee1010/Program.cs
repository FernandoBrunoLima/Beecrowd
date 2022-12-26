using System.Globalization;

namespace Bee1010
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dadosPeca1 = Console.ReadLine();
            string dadosPeca2 = Console.ReadLine();

            string[] vet = dadosPeca1.Split(' ');
            int codigoPeca1 = int.Parse(vet[0]);
            int qtdPecas1 = int.Parse(vet[1]);
            double valorUnitario1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet2 = dadosPeca2.Split(' ');
            int codigoPeca2 = int.Parse(vet2[0]);
            int qtdPecas2 = int.Parse(vet2[1]);
            double valorUnitario2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double totalPeca1 = qtdPecas1 * valorUnitario1;
            double totalPeca2 = qtdPecas2 * valorUnitario2;

            double TotalAPagar = totalPeca1 + totalPeca2;

            Console.WriteLine($"VALOR A PAGAR: R$ {TotalAPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}