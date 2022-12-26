// Bee 1035 - Selection Test 1
using System;
namespace Bee1035
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variables
            int numA, numB, numC, numD;
                       
            // input
            string[] numberList = Console.ReadLine().Split(' ');

            numA = int.Parse(numberList[0]);
            numB = int.Parse(numberList[1]);
            numC = int.Parse(numberList[2]);
            numD = int.Parse(numberList[3]);


            if (numB > numC && numD > numA && (numC + numD) > (numA + numB) && numC > 0 && numD > 0 && (numA%2==0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
