using System;

namespace Bee1049_Animal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string palavra1, palavra2, palavra3;

            palavra1 = Console.ReadLine();

            if (palavra1 == "vertebrado")
            {
                palavra2 = Console.ReadLine();
                if (palavra2 == "ave") {
                    palavra3= Console.ReadLine();
                    if (palavra3 == "carnivoro")
                        Console.WriteLine("aguia");
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                if (palavra2 == "mamifero")
                {
                    palavra3 = Console.ReadLine();
                    if (palavra3 == "onivoro")
                        Console.WriteLine("homem");
                    if (palavra3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            if (palavra1 == "invertebrado")
            {
                palavra2 = Console.ReadLine();
                if (palavra2 == "inseto")
                {
                    palavra3= Console.ReadLine();
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    if (palavra3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                if (palavra2 == "anelideo")
                {
                    palavra3 = Console.ReadLine();
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }
    }
}
