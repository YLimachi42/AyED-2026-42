using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cantidad de minutos: ");
            int min = int.Parse(Console.ReadLine());
            int horas = min / 60;
            int mins = min % 60;
            Console.Write("La cantidad en horas es: " + horas + " horas y " + mins + " minutos.");
            Console.ReadKey();
        }
    }
}
