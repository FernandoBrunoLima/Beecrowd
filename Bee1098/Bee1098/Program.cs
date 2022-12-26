using System;
using System.Globalization;

namespace Bee1098
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double i, j;
            for (i = 0; i <= 2; i += 0.2)
            {
                for (j = 1; j <= 3; j++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine($"I={i.ToString("0.##", CultureInfo.InvariantCulture)} J={j.ToString("0.##", CultureInfo.InvariantCulture)}");
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine($"I={i.ToString("0.##", CultureInfo.InvariantCulture)} J={(j + i).ToString("0.##", CultureInfo.InvariantCulture)}");
                    }
                    else if (i > 1.9)
                    {
                        Console.WriteLine($"I={i.ToString("0.##", CultureInfo.InvariantCulture)} J={(j + i).ToString("0.##", CultureInfo.InvariantCulture)}");
                    }
                    else
                    {
                        Console.WriteLine($"I={i.ToString("0.##", CultureInfo.InvariantCulture)} J={(j + i).ToString("0.##", CultureInfo.InvariantCulture)}");
                    }
                }
            }
        }
    }
}