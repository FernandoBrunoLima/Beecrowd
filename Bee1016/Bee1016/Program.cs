// Bee 1016 - Distância
using System;

namespace Bee1016
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Data
            // carroX = 60 km/h; carroY = 90 km/h
            // 90 - 60: a cada 60min a distancia aumenta 30 km
            // a cada 2 min a distancia dobra

            // Variables
            int distancia, minutos;

            // Input
            distancia = int.Parse(Console.ReadLine());

            // Code
            minutos = (60 * distancia)/30;

            // Output
            Console.WriteLine($"{minutos} minutos");

         }
    }
}