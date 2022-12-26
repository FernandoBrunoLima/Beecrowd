using System;
using System.Globalization;

namespace Bee1079
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberN; i++)
            {
                string[] threeMedia = Console.ReadLine().Split();

                double numberX = double.Parse(threeMedia[0], CultureInfo.InvariantCulture);
                double numberY = double.Parse(threeMedia[1], CultureInfo.InvariantCulture);
                double numberZ = double.Parse(threeMedia[2], CultureInfo.InvariantCulture);

                double media = ((numberX*2)+(numberY*3)+(numberZ*5))/10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));


            }
        }
    }
}
