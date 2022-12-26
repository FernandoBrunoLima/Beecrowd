using System;

namespace Bee1114
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int userPassword = 2002;
            int inseredPassword = int.Parse(Console.ReadLine());
            
            while (inseredPassword != userPassword)
            {
                Console.WriteLine("Senha Invalida");
                inseredPassword = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
