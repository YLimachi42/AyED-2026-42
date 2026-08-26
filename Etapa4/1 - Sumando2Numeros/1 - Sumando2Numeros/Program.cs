using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Sumando2Numeros
{
    class Program
    {
        static int Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        static void Main(string[] args)
        {
            Console.Write("Introduzaca el numero 1: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzaca el numero 2: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {Sumar(numero1, numero2)}");
            Console.ReadKey();

        }
    }
}
