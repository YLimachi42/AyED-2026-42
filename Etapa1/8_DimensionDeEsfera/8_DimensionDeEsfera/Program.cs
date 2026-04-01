using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.141692;
            Console.Write("Radio: ");
            float radio = float.Parse(Console.ReadLine());
            double superficie = 4 * pi * (radio * radio);
            double volumen = (radio * radio * radio) * pi * 4 / 3;
            Console.Write("La superficie es: "+ superficie);
            Console.Write("El volumen es: " + volumen);
            Console.ReadKey();
        }
    }
}
