using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 3 números enteros para calcular su promedio.");
            Console.Write("Ingrese el número 1: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el número 2: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el número 3: ");
            float num3 = float.Parse(Console.ReadLine());
            float promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
