using System;

namespace Bee1047
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] horaMinutos = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(horaMinutos[0]),
                minutoInicial = int.Parse(horaMinutos[1]),
                horaFinal = int.Parse(horaMinutos[2]),
                minutoFinal = int.Parse(horaMinutos[3]),
                duracao, hora, minutos;

            minutoInicial += horaInicial * 60;
            minutoFinal += horaFinal * 60;

            duracao = minutoFinal - minutoInicial;

            if (duracao <= 0)
            {
                duracao += 24 * 60;
            }

            hora = (int) duracao / 60;
            minutos = duracao % 60;


            Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {minutos} MINUTO(S)");
        }
    }
}
