using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una medida en metros: ");
            int metros = int.Parse(Console.ReadLine());
            int cent = metros * 100;
            int mil = metros * 1000;
            Console.WriteLine("La medida en centimetros es: " + cent);
            Console.WriteLine("La medida en milimetros es: " + mil);
            Console.ReadKey();
        }
    }
}
