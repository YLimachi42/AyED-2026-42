using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("ingrese la cantidad de filas de la matriz: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese la cantidad de columnas de la matriz: ");
        int y = int.Parse(Console.ReadLine());
        int[,] matriz = new int[x, y];
        Console.WriteLine("ingrese valores para la matriz");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("la matriz es asi");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("la matriz traspuesta es asi");
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(matriz[j, i] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
