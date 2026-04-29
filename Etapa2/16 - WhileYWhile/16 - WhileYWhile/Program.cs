using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números del 0 a 100.");
            int contador = 0;
            Console.WriteLine("Impares:");
            while (contador <= 100)
            {
                if(contador % 2 != 0)
                {
                    Console.Write(contador + " ");
                }
                contador = contador + 1;
            }
            contador = 0;
            Console.WriteLine("");

            Console.WriteLine("Pares:");
            while (contador <= 100)
            {
                if (contador % 2 == 0)
                {
                    Console.Write(contador + " ");
                }
                contador = contador + 1;
            }
            contador = 0;
            Console.WriteLine("");

            Console.WriteLine("De 0 a 100:");
            while (contador <= 100)
            {
                Console.Write(contador + " ");
                contador = contador + 1;
            }
            contador = 100;
            Console.WriteLine("");

            Console.WriteLine("De 100 a 0:");
            while (contador >= 0)
            {
                Console.Write(contador + " ");
                contador = contador - 1;
            }
            contador = 0;
            Console.WriteLine("");

            Console.WriteLine("Multiplos de 3:");
            while (contador <= 100)
            {
                if (contador % 3 == 0)
                {
                    Console.Write(contador + " ");
                }
                contador = contador + 1;
            }
            contador = 0;
            Console.WriteLine("");

            Console.WriteLine("Multiplos de 2 y 3:");
            while (contador <= 100)
            {
                if (contador % 2 == 0 && contador % 3 == 0)
                {
                    Console.Write(contador + " ");
                }
                contador = contador + 1;
            }
            Console.ReadKey();
        }
    }
}
