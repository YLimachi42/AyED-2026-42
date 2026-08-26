using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0___HolaNombre
{
    class Program
    {
        static void Saludar()
        {
            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"\nHola {nombre}");
        }

        static void Main(string[] args)
        {
            Saludar();
            Console.ReadKey();
        }
    }
}
