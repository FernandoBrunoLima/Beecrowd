using System;
using System.Globalization;

namespace Bee1043_Triangulo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double numA, numB, numC, area, perimetro;

            string[] valoresReais = Console.ReadLine().Split(' ');
            numA = double.Parse(valoresReais[0], CultureInfo.InvariantCulture);
            numB = double.Parse(valoresReais[1], CultureInfo.InvariantCulture);
            numC = double.Parse(valoresReais[2], CultureInfo.InvariantCulture);

            if (numA < numB + numC && numB < numA + numC && numC < numA + numB)
            {
                perimetro = numA + numB + numC;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((numA + numB) * numC) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
