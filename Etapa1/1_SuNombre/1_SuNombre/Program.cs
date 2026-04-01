using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SuNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su Nombre:");
            String nombre = Console.ReadLine();
            Console.WriteLine("Su nombre es: " + nombre);
            Console.ReadKey();
        }
    }
}
