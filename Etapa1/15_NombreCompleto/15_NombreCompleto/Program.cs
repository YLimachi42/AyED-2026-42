using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            String name = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            String apellido = Console.ReadLine();
            Console.WriteLine("Su nombre y apellido es: " + name + " " + apellido);
            Console.ReadKey();
        }
    }
}
