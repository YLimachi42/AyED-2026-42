using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su Nombre: ");
            String name = Console.ReadLine();
            Console.Write("Ingrese su Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su Ciudad: ");
            String ciudad = Console.ReadLine();
            Console.WriteLine("Su nombre es " + name + " tiene " + edad + " años y vive en " + ciudad);
            Console.ReadKey();
        }
    }
}
