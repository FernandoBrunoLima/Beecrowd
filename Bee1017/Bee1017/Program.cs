// Bee1017 - gasto de combustivel
using System;
using System.Globalization;

namespace Bee1017
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Dados: carro faz 12km/h
            // Informar tempo gasto na viagem (em horas) e velocidade media durante a mesma (em km/h)
            // obter distancia percorrida e calcular litros necessarios (3 casas decimais))

            // Variables
            int tempoGastoH, velocidadeMediaKmH;
            double totalKmPercorrido, qtdLitrosNecessarios;

            // Input
            tempoGastoH= int.Parse(Console.ReadLine());
            velocidadeMediaKmH = int.Parse(Console.ReadLine());

            // Code
            totalKmPercorrido = tempoGastoH * velocidadeMediaKmH;
            qtdLitrosNecessarios = totalKmPercorrido / 12;
            
            // Output
            Console.WriteLine($"{qtdLitrosNecessarios.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}

