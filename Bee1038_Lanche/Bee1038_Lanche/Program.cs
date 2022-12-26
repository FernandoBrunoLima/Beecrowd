using System;
using System.Globalization;

namespace Bee1038_Lanche
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variables
            int codigo, quantidade;
            string[] dadosInformados;
            double total;

            // input
            dadosInformados = Console.ReadLine().Split(' ');

            codigo = int.Parse(dadosInformados[0]);
            quantidade = int.Parse(dadosInformados[1]);

            // code

            if (codigo == 1)
            {
                // cachorro quente - R$ 4.00
                Console.WriteLine($"Total: R$ {(total = quantidade * 4.00).ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 2)
            {
                // x-salada - R$ 4.50
                Console.WriteLine($"Total: R$ {(total = quantidade * 4.50).ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 3)
            {
                // x-bacon - R$ 5.00
                Console.WriteLine($"Total: R$ {(total = quantidade * 5.00).ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 4)
            {
                // torrada simples - R$ 2.00
                Console.WriteLine($"Total: R$ {(total = quantidade * 2.00).ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 5)
            {
                // refrigerante - R$ 1.50
                Console.WriteLine($"Total: R$ {(total = quantidade * 1.50).ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Codigo invalido");
            }

            
        }
    }
}
