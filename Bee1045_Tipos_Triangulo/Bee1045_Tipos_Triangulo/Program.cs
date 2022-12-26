using System;

namespace Bee1045_Tipos_Triangulo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double numA = double.Parse(valores[0]);
            double numB = double.Parse(valores[1]);
            double numC = double.Parse(valores[2]);

            if (numC > numA && numC > numB)
            {
                double temp = numC;
                numC = numA;
                numA = temp;
            }
            else if (numB > numA && numB > numC)
            {
                double temp = numB;
                numB = numA;
                numA = temp;
            }

            if (numC > numB)
            {
                double temp = numC;
                numC = numB;
                numB = temp;
            }


            if (numA >= numB + numC)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (numA * numA == numB * numB + numC * numC)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (numA * numA > numB * numB + numC * numC)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (numA * numA < numB * numB + numC * numC)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            
            if (numA == numB && numA == numC)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (numA == numB || numA == numC || numB == numC){
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}