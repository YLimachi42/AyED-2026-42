using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para calcular su cuadrado y cubo: ");
            int num = int.Parse(Console.ReadLine());

            double cuadrado = Math.Pow(num, 2);
            double cubo = Math.Pow(num, 3);

            Console.WriteLine("El cuadrado del número es: " + cuadrado);
            Console.WriteLine("El cubo del número es: " + cubo);
            Console.ReadKey();
        }
    }
}
