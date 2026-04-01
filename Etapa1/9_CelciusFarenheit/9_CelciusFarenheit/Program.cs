using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cantidad de grados Celcius para transformarlos a Kelvin y Farenheit");
            Console.Write("Grados Celcius: ");
            float cel = float.Parse(Console.ReadLine());
            float far = (cel * 9) / 5 + 32;
            double kel = 273.15 + cel;
            Console.WriteLine("Grados en Farenheit: " + far);
            Console.WriteLine("Grados en Kelvin: " + kel);
            Console.ReadKey();
        }
    }
}
