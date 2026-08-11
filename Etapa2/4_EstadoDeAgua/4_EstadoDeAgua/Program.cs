using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una temperatura del agua en grados celsius: ");
            int temp = int.Parse(Console.ReadLine());
            if (temp <= 0)
            {
                Console.WriteLine("Se congela.");
            }
            if (temp >= 100)
            {
                Console.WriteLine("Hierve");
            }
            if (temp > 0 && temp < 100)
            {
                Console.WriteLine("Está en estado liquido");
            }
            Console.ReadKey();
        }
    }
}
