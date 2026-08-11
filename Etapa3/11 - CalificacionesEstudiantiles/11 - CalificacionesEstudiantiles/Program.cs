using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Ingrese la cantidad de alumnos:");
            int cantidad = int.Parse(Console.ReadLine());
            String[,] matriz = new String[cantidad, 3];
            for (int j = 0; j < cantidad; j++)
            {
                for (int f = 0; f < 3; f++)
                {
                    if (f == 0)
                    {
                        Console.Write("Ingrese el nombre del alumno: ");
                        matriz[j, f] = Console.ReadLine();
                    }
                    else if (f == 1)
                    {
                        Console.Write("Ingrese la edad del alumno: ");
                        matriz[j, f] = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Ingrese la calificación del alumno: ");
                        matriz[j, f] = Console.ReadLine();
                    }
                }
            }
            for (int x = 0; x < cantidad; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(matriz[x, y] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
