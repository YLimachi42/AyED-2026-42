using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de cilindros del disco duro: ");
            int cilindros = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de pistas por cilindro: ");
            int pistas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de sectores por pista: ");
            int sectores = int.Parse(Console.ReadLine());
            int cap = 512 * sectores * pistas * cilindros;
            float kilo = cap / 1024;
            float mega = kilo / 1024;
            float giga = mega / 1024;
            Console.WriteLine("La capacidad en kilobytes es: " + kilo);
            Console.WriteLine("La capacidad en megabytes es: " + mega);
            Console.WriteLine("La capacidad en gigabytes es: " + giga);
            Console.ReadKey();
        }
    }
}
