using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número como limite: ");
            int num = int.Parse(Console.ReadLine());
            int contador = 1;
            while (contador <= num)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador = contador + 1;
            }
            Console.ReadKey();
        }
    }
}
