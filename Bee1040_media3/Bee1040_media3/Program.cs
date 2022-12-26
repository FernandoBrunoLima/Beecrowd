using System;
using System.Globalization;

namespace Bee1040_Media3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variables
            string[] numberList;
            double num1, num2, num3, num4, media;

            // input
            numberList = Console.ReadLine().Split(' ');

            num1 = double.Parse(numberList[0], CultureInfo.InvariantCulture);
            num2 = double.Parse(numberList[1], CultureInfo.InvariantCulture);
            num3 = double.Parse(numberList[2], CultureInfo.InvariantCulture);
            num4 = double.Parse(numberList[3], CultureInfo.InvariantCulture);

            // code
            media = (Math.Truncate((num1 * 2) + (num2 * 3) + (num3 * 4) + (num4 * 1))) / 10;
            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0 && media >= 0.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0 && media < 7.0)
            {
                Console.WriteLine("Aluno em exame.");

                // input of exam grade
                double examGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {examGrade.ToString("F1", CultureInfo.InvariantCulture)}");

                media = (media + examGrade) / 2;

                if (media >= 5.0 && media <= 10.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                }
                else if (media >= 0 && media < 5.0)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                else
                {
                    Console.WriteLine("Erro. Recalcular média.");
                }
            }
            else
            {
                Console.WriteLine("Erro. Recalcular média.");
            }
        }
    }
}
