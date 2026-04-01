using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la longitud de un lado de un cuadrado para calcular su perimetro y superficie.");
            Console.Write("Longitud: ");
            int longitud = int.Parse(Console.ReadLine());
            int perimetro = longitud * 4;
            int superficie = longitud * longitud;
            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
            Console.WriteLine("La superficie del cuadrado es: " + superficie);
            Console.ReadKey();
        }
    }
}
