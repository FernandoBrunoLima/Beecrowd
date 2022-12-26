using System;

public class Program
{
    public static void Main(string[] args)
    {
        int valorInteiro = int.Parse(Console.ReadLine());
               

        for (int i = 0; i <= valorInteiro+11; i++)
        {

            if (i % 2 != 0 && i >= valorInteiro)
            {

                Console.WriteLine(i);
            }
        }
    }
}
