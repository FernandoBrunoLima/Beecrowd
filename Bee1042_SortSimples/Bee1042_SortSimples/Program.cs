using System;

namespace Bee1042_SortSimples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int numA = int.Parse(valores[0]);
            int numB = int.Parse(valores[1]);
            int numC = int.Parse(valores[2]);

            int numAA = numA;
            int numBB = numB;
            int numCC = numC;

            if (numAA > numBB && numAA > numCC)
            {
                int temp = numAA;
                numAA = numCC;
                numCC = temp;
            }
            else if (numBB > numAA && numBB > numCC)
            {
                int temp = numBB;
                numBB = numCC;
                numCC = temp;
            }

            if (numAA > numBB)
            {
                int temp = numAA;
                numAA = numBB;
                numBB = temp;
            }

            Console.WriteLine(numAA);
            Console.WriteLine(numBB);
            Console.WriteLine(numCC);
            Console.WriteLine();
            Console.WriteLine(numA);
            Console.WriteLine(numB);
            Console.WriteLine(numC);        
            
        }
    }
}

//Array.Sort(valores);

//for(int i = 0; i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}