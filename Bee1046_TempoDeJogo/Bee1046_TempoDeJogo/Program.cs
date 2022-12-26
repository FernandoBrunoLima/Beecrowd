using System;

namespace Bee1046_TempoDeJogo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] horaInicioFim = Console.ReadLine().Split();
            int horaInicio = int.Parse(horaInicioFim[0]);
            int horaFim = int.Parse(horaInicioFim[1]);
            int tempoDuracao;

            if (horaInicio < horaFim)
            {
                tempoDuracao = horaFim - horaInicio;
            }
            else
            {
                tempoDuracao = (24 - horaInicio) + horaFim;
            }

            Console.WriteLine($"O JOGO DUROU {tempoDuracao} HORA(S)");
        }
    }
}
