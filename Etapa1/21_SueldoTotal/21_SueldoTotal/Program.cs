using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor por hora: ");
            int valor = int.Parse(Console.ReadLine());
            int pago = horas * valor;
            Console.WriteLine("El pago por la cantidad de horas trabajadas es: " + pago);
            Console.ReadKey();
        }
    }
}
