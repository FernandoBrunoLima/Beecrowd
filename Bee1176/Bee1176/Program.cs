using System;

namespace Bee1176
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int valueT;
            int valueN;
            decimal a = 0, b = 1, c = 0;

            decimal[] fib = new decimal[61];

            for (int i = 0; i < fib.Length; i++)
            {
                fib[i] = c;
                a = b;
                b = c;
                c = a + b;
            }


            valueT = int.Parse(Console.ReadLine());

            for (int i = 0; i < valueT; i++)
            {
                valueN = int.Parse(Console.ReadLine());
                Console.WriteLine($"Fib({valueN}) = {fib[valueN]}");
            }
        }
    }
}
