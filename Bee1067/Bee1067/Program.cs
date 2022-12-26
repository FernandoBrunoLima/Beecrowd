using System;

public class Program
{
    public static void Main(string[] args)
    {
        int valorInteiro;
        int numerosImpares = 1;

        valorInteiro= int.Parse(Console.ReadLine());

        for (int i = 0; i <= valorInteiro; i++)
        {
            
            if (i % 2 != 0)
            {   

                Console.WriteLine(i);
            }
        }
    }
}
