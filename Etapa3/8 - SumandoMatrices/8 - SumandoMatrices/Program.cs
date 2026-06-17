using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Ingrese la cantidad de filas y columnas de las matrices:");
            int espacio = int.Parse(Console.ReadLine());
            int[,] matriz1 = new int[espacio, espacio];
            int[,] matriz2 = new int[espacio, espacio];
            int[,] matrizSumada = new int[espacio, espacio];

            for (int x = 0; x < espacio; x++)
            {
                for (int y = 0; y < espacio; y++)
                {
                    matriz1[x, y] = random.Next(1, 101);
                    matriz2[x, y] = random.Next(1, 101);
                }
            }

            for (int x = 0; x < espacio; x++)
            {
                for (int y = 0; y < espacio; y++)
                {
                    matrizSumada[x, y] = matriz1[x, y] + matriz2[x, y];
                    Console.Write(matrizSumada[x, y] + " ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
