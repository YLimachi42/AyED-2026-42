using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un Año: ");
            int año = int.Parse(Console.ReadLine());
            bool bi = false;
            if (año % 4 == 0)
            {
                bi = true;
                if (año % 100 == 0)
                {
                    bi = false;
                    if (año % 400 == 0)
                    {
                        bi = true;
                    }
                }
            }
            if (bi == true)
            {
                Console.WriteLine("El año es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto.");
            }
            Console.ReadKey();
        }
    }
}
