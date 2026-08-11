using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___MatrizRotada90
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Ingrese la cantidad de filas de las matrices:");
            int espacio = int.Parse(Console.ReadLine());
            int[,] matrizNormal = new int[espacio, espacio];
            int[,] matrizRotada = new int[espacio, espacio];

            for (int x = 0; x < espacio; x++)
            {
                for (int y = 0; y < espacio; y++)
                {
                    matrizNormal[x, y] = random.Next(1, 101);
                }
            }

            for (int x = 0; x < espacio; x++)
            {
                for (int y = 0; y < espacio; y++)
                {
                    Console.Write(matrizNormal[x, y] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\t");
            for (int y = 0; y < espacio; y++)
            {
                for (int x = espacio - 1; x >= 0; x--)
                {
                    Console.Write(matrizNormal[x, y] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
