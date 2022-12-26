using System.Globalization;

namespace Bee1005_Average1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A, B, MEDIA, W1, W2;

            W1 = 3.5;
            W2 = 7.5;

            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            A = A * W1;
            B = B * W2;

            MEDIA = (A + B) / 11;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}
