using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad monedas plateadas consiguidas: ");
            int oro = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de monedas plateadas consiguidas: ");
            int plata = int.Parse(Console.ReadLine());
            int puntos = (oro * 10) + (plata * 2);
            if (puntos < 50)
            {
                Console.WriteLine("Tiene " + puntos + " puntos. Nivel Insuficiente.");
            }
            if (puntos >= 50 && puntos < 100)
            {
                Console.WriteLine("Tiene " + puntos + " puntos. Nivel Superado.");
            }
            if (puntos >= 100)
            {
                Console.WriteLine("Tiene " + puntos + " puntos- Nivel Superado con Bonus.");
            }
            Console.ReadKey();
        }
    }
}
