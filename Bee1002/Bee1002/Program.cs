using System.Globalization;

namespace AreaOfACircle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double p = 3.14159;
            double A;

            A = p * Math.Pow(R, 2);

            Console.WriteLine($"A={A.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
