using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarioBros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = { 659, 659, 659, 523, 659, 784, 392, 523, 392, 330, 440, 494, 466, 440, 392, 659, 784, 880, 698, 784, 659, 523, 587, 494, 523, 392, 330, 440, 494, 466, 440, 392 };
            int duracion = 200; // Duración de cada nota en milisegundos

            // Reproducir las notas
            foreach (int nota in notas)
            {
                Console.Beep(nota, duracion);
                Thread.Sleep(50); // Pausa entre notas
            }
        }
    }
}
