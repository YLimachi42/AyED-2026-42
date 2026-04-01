using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MiSuma
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Ingrese 2 Números.");
         Console.Write("Ingrese el Primer Número: ");
         int num1 = int.Parse(Console.ReadLine());
         Console.WriteLine("");
         Console.Write("Ingrese el Segundo Número: ");
         int num2 = int.Parse(Console.ReadLine());
         Console.WriteLine("");
         int resultado = num1 + num2;
         Console.WriteLine("La suma de ámbos números es: " + resultado);
         Console.ReadKey();
        }
    }
}
