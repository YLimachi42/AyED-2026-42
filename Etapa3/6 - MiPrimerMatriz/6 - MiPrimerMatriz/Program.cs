using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de filas de la matriz:");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas de la matriz:");
            int columna = int.Parse(Console.ReadLine());
            int[,] matriz = new int[fila, columna];
            for (int x = 0; x < fila; x++)
            {
                for (int y = 0; y < columna; y++)
                {
                    Console.Write(matriz[x, y]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
