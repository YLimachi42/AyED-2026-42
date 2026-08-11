using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            float comida = 0;
            bool NumeroValido = false;
            Console.Write("Ingrese la cantidad de invitados: ");
            int CantidadInvitados = int.Parse(Console.ReadLine());
            float[] CantidadComida = new float[CantidadInvitados];
            for (int y = 0; y < CantidadComida.Length; y++)
            {
                while (!NumeroValido)
                {
                    Console.Write($"Ingrese la cantidad que come el invitado {y + 1}: ");
                    float invitado = float.Parse(Console.ReadLine());
                    if (invitado > 0 && invitado < 101)
                    {
                        CantidadComida[y] = invitado;
                        NumeroValido = true;
                    }
                    else { Console.WriteLine("Ingrese un número válido (entre 1 y 100).\n"); }
                }
                NumeroValido = false;
            }
            for (int x = 0; x < CantidadComida.Length; x++)
            {
                comida += CantidadComida[x];
            }
            float promedio = comida / CantidadInvitados;
            Console.WriteLine("El promedio de comida por invitado es: " + promedio);
            Console.ReadKey();
        }
    }
}
