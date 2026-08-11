using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un Número para calcular su doble y triple: ");

            int num = int.Parse(Console.ReadLine());

            int doble = num * 2;
            int triple = num * 3;

            Console.WriteLine("El doble del número es: " + doble);
            Console.WriteLine("El triple del número es: " + triple);
            Console.ReadKey();
        }
    }
}
