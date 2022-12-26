// Bee 1019 - Conversão de tempo
using System;
using System.Globalization;

namespace Bee1019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N, horas, minutos, segundos, segRestantes;

            // entrada em segundos
            N= int.Parse(Console.ReadLine());

            // 1h tem 3600 segundos
            horas= N/3600;
            segRestantes = N%3600;

            // 1min tem 60seg
            minutos= segRestantes/60;
            segundos= segRestantes%60;

            // saida
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
