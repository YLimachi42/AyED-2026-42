using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base de un triangulo: ");
            int bas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura de un triangulo: ");
            int alt = int.Parse(Console.ReadLine());
            int area = (bas * alt) / 2;
            Console.WriteLine("El area del triangulo es: " + area);
            Console.ReadKey();
        }
    }
}
