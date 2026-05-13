using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            float ProductoMasCaro = 0;
            float ProductoMasBarato = 0;
            Console.Write("Ingrese la cantidad de productos vendidos: ");
            int ProductosVendidos = int.Parse(Console.ReadLine());

            float[] PreciosProductos = new float[ProductosVendidos];
            for (int i = 0; i < ProductosVendidos; i++)
            {
                Console.Write($"Ingrese el precio del producto {i + 1}: ");
                PreciosProductos[i] = float.Parse(Console.ReadLine());
            }
            ProductoMasCaro = PreciosProductos[0];
            for (int y = 0; y < ProductosVendidos - 1; y++)
            {
                if (ProductoMasCaro < PreciosProductos[y + 1])
                {
                    ProductoMasCaro = PreciosProductos[y + 1];
                }
            }
            ProductoMasBarato = PreciosProductos[0];
            for (int y = 0; y < ProductosVendidos - 1; y++)
            {
                if (ProductoMasBarato > PreciosProductos[y + 1])
                {
                    ProductoMasBarato = PreciosProductos[y + 1];
                }
            }
            Console.WriteLine("El producto mas caro se vendió por: " + ProductoMasCaro);
            Console.WriteLine("El producto mas barato se vendió por: " + ProductoMasBarato);
            Console.ReadKey();
        }
    }
}
