using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Ingrese la cantidad de filas de las matrices:");
            int espacio = int.Parse(Console.ReadLine());
            int[,] matriz = new int[espacio, espacio];
            int[] diagonal = new int[espacio];
            for (int x = 0; x < espacio; x++)
            {
                for (int y = 0; y < espacio; y++)
                {
                    matriz[x, y] = random.Next(1, 101);
                    Console.Write(matriz[x, y] + " ");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < espacio; i++)
            {
                for (int j = 0; j < espacio; j++)
                {
                    if (i == j) { diagonal[j] = matriz[i, j]; }
                }
            }
            Console.WriteLine("\nDiagonal:");
            for (int z = 0; z < espacio; z++) { Console.Write($"{diagonal[z]} "); }
            Console.ReadKey();
        }
    }
}
