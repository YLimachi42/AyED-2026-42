using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Ingrese la cantidad de filas de la matriz:");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas de la matriz:");
            int columna = int.Parse(Console.ReadLine());
            int[,] matriz = new int[fila, columna];

            for (int i = 0; i < fila; i++)
            {
                for (int z = 0; z < columna; z++)
                {
                    matriz[i, z] = random.Next(1, 101);
                    Console.Write(matriz[i, z] + " ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
