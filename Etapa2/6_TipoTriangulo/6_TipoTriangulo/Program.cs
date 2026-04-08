using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer lado del triángulo: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo lado: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer lado: ");
            int lado3 = int.Parse(Console.ReadLine());
            if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
            {
                Console.WriteLine("Se puede armar un triángulo.");
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Es un triángulo equilatero.");
                }
                if (lado1 != lado2 && lado2 != lado3)
                {
                    Console.WriteLine("Es un triángulo escaleno.");
                }
                if ((lado1 == lado2 && lado2 != lado3) || (lado2 == lado3 && lado2 != lado1) || (lado1 == lado3 && lado1 != lado2))
                {
                    Console.WriteLine("Es un triángulo Isóceles.");
                }
            }
            else
            {
                Console.WriteLine("No se puede armar un triángulo.");
            }
            Console.ReadKey();
        }
    }
}
