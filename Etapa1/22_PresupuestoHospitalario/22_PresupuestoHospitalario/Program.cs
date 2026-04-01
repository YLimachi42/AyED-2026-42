using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el presupuesto anual para el hospital: ");
            float pres = float.Parse(Console.ReadLine());
            float gine = (pres / 10) * 4;
            float traped = (pres / 10) * 3;
            Console.WriteLine("El área de Ginecología recibe: " + gine + "$");
            Console.WriteLine("El área de Traumatología recibe: " + traped + "$");
            Console.WriteLine("El área de Pediatría recibe: " + traped + "$");
            Console.ReadKey();
        }
    }
}
