using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("¿Cuánto gana por mes? ");
            float ing = float.Parse(Console.ReadLine());
            if ((edad > 19 && ing <= 100000) || (edad < 19 && ing == 0) || (edad == 19 && ing <= 50000))
            {
                Console.WriteLine("Puede cobrar la beca.");
            }
            else
            {
                Console.WriteLine("No puede cobrar la beca.");
            }
            Console.ReadKey();
        }
    }
}
