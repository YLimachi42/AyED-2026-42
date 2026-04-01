using System;

namespace ConsoleApplication1
{
    public class ejercicio
    {
        public static void Main()
        {
            Console.WriteLine("ingrese el precio de un producto");
            double precio = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el descuento");
            double descuento = int.Parse(Console.ReadLine());
            double precio_final = precio - (precio * descuento /100);
            Console.WriteLine("el precio final con IVA es = " + precio_final );
            Console.ReadKey();
        }
    }
}
