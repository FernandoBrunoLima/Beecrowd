// Bee 1012 - Área
using System.Globalization;

namespace Bee1012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variaveis
            double A, B, C, pi = 3.14159;
            double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            // entrada de bases e altura
            string[] vet = (Console.ReadLine().Split(' '));

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            // a) a área do triângulo retângulo que tem A por base e C por altura.
            areaTriangulo = A * C / 2;
            // b) a área do círculo de raio C. (pi = 3.14159)
            areaCirculo = pi * Math.Pow(C, 2);
            // c) a área do trapézio que tem A e B por bases e C por altura.
            areaTrapezio = (A+B)*C/ 2;
            // d) a área do quadrado que tem lado B.
            areaQuadrado = Math.Pow(B, 2);
            // e) a área do retângulo que tem lados A e B.
            areaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}

