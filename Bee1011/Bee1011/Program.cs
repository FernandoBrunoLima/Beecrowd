//Beecrowd 1011 - Esfera
using System.Globalization;

namespace Bee1011
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double pi = 3.14159, volume, R;
            
            R = double.Parse(Console.ReadLine());

            volume = (4.0/3) * pi * Math.Pow(R, 3);

            Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}

