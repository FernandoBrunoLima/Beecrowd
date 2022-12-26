using System;

public class Program
{
    public static void Main(string[] args)
    {
        int valueX = int.Parse(Console.ReadLine());
        int valueY = int.Parse(Console.ReadLine());

        int soma = 0;

        if (valueX > valueY)
        {
            int aux = valueY;
            valueY = valueX;
            valueX = aux;
        }

        for (int i = valueX; i <= valueY; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);

    }
}