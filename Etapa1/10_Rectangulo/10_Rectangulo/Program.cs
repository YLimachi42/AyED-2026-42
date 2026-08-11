using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el ancho y alto de un rectangulo para calcular su perímetro, área y diagonal.");
            Console.Write("Ingrese el Alto: ");
            float alto = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el Ancho: ");
            float ancho = float.Parse(Console.ReadLine());
            float perimetro = 2 * (ancho + alto);
            float area = ancho * alto;
            double diagonal = Math.Sqrt((Math.Pow(ancho, 2)) + (Math.Pow(alto, 2)));
            Console.WriteLine("El perimetro es: " + perimetro);
            Console.WriteLine("El area es: " + area);
            Console.WriteLine("La diagonal es: " + diagonal);
            Console.ReadKey();
        }
    }
}