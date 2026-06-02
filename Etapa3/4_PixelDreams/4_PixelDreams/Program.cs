using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de jugadores: ");
            int jugadores = int.Parse(Console.ReadLine());

            int[] puntos = new int[jugadores];
            for (int y = 0; y < jugadores; y++)
            {
                Console.Write($"Ingrese el puntaje del jugador {y + 1}:");
                puntos[y] = int.Parse(Console.ReadLine());
            }
            Array.Sort(puntos);
            Array.Reverse(puntos);
            Console.WriteLine("Lista de puntajes:");
            for (int z = 0; z < jugadores; z++)
            {
                Console.WriteLine($"Top {z + 1}: {puntos[z]}");
            }
            Console.WriteLine($"Primer lugar: {puntos[0]}\nUltimo lugar: {puntos[jugadores - 1]}");
            Console.ReadKey();
        }
    }
}
