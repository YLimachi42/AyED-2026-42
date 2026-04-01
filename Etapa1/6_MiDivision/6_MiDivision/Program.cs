using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 2 Números para dividirlos.");
            Console.Write("Ingrese el Primer Número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Ingrese el Segundo Número: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = num1 % num2;
            Console.WriteLine("El resultado de la división de ámbos números es: " + resultado);
            Console.ReadKey();
        }
    }
}
