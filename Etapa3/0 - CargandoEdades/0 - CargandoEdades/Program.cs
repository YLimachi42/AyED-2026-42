using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0___CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[5];
            for (int i = 1; i <= edades.Length; i++)
            {
                Console.Write($"Ingrese la edad del alumno {i}:");
                edades[i - 1] = int.Parse(Console.ReadLine());
            }
            for (int y = 0; y < edades.Length; y++)
            {
                Console.WriteLine($"Edad alumno {y + 1}: {edades[y]}");
            }
            Console.ReadKey();
        }
    }
}
