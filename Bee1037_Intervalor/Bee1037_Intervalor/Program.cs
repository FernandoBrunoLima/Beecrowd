using System;
using System.Globalization;

namespace Bee1037_Intervalo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variables
            double givenNumber;

            // input
            givenNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // code
            if (givenNumber>=0 && givenNumber <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (givenNumber >= 25.0001 && givenNumber <= 50.0000000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (givenNumber >= 50.0000001 && givenNumber <= 75.0000000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (givenNumber >= 75.0000001 && givenNumber <= 100.0000000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
