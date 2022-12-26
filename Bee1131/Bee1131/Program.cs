using System;

namespace Bee1131
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Inter = 0;
            int Gremio = 0;
            int empates = 0;
            int resultado = 0;
            int novoGrenal = 1;

            do
            {
                {
                    string[] valores = Console.ReadLine().Split(' ');
                    int golsInter = int.Parse(valores[0]);
                    int golsGremio = int.Parse(valores[1]);

                    if (golsInter > golsGremio)
                    {
                        Inter += 1;
                    }
                    else if (golsGremio > golsInter)
                    {
                        Gremio += 1;
                    }
                    else
                    {
                        empates += 1;
                    }

                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    novoGrenal = int.Parse(Console.ReadLine());

                    while (novoGrenal != 1 && novoGrenal != 2)
                    {
                        Console.WriteLine("Novo grenal (1-sim 2-nao)");
                        novoGrenal = int.Parse(Console.ReadLine());
                    }
                }

                resultado = Gremio + Inter + empates;              
                

                
            }
            while (novoGrenal == 1);

            Console.WriteLine($"{resultado} grenais");
            Console.WriteLine($"Inter:{Inter}");
            Console.WriteLine($"Gremio:{Gremio}");
            Console.WriteLine($"Empates:{empates}");

            if (Inter > Gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (Gremio > Inter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}