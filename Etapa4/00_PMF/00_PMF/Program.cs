using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_PMF
{
    class Program
    {
        static void Main(string[] args)
        {
            SaludarA("Beni");
            int a = 3, b = 5, c = 2;
            Console.WriteLine(Sumar(5, 3));
            Console.WriteLine(Sumar(3, 2));
            Console.WriteLine(Sumar(Sumar(b, a), Sumar(a, c)));
        }
        static void SaludarA(String nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
        static int SumarDos(int n)
        {
            int resultado = n + 2;
            return resultado;
        }
        static int Sumar(int n, int n2)
        {
            int resultado = n + n2;
            return resultado;
        }
    }
}
