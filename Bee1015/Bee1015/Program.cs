// Bee 1015 - DistÂncia entre dois pontos
using System;
using System.Globalization;

namespace Bee1015
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variables
            string p1, p2;
            double x1, y1, x2, y2, distancia;

            // Input
            p1 = Console.ReadLine();
            p2 = Console.ReadLine();

            string[] vet1 = p1.Split(' ');
            string[] vet2 = p2.Split(' ');

            x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            // Code
            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            // Output
            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
