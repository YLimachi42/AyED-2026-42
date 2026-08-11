using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Tienes comida? ");
            bool comida = Console.ReadLine().ToLower() == "si";
            Console.Write("¿Tienes refugio? ");
            bool refugio = Console.ReadLine().ToLower() == "si";
            Console.Write("¿Tienes un bate? ");
            bool bate = Console.ReadLine().ToLower() == "si";
            Console.Write("¿Tienes un botiquin? ");
            bool botiquin = Console.ReadLine().ToLower() == "si";
            Console.Write("¿Estas solo? ");
            bool solo = Console.ReadLine().ToLower() == "no";
            if ((comida == true && refugio == true || bate == true) || (comida == false && botiquin == true || solo == true))
            {
                Console.WriteLine("Sobrevives.");
            }
            else
            {
                Console.WriteLine("No sobrevives.");
            }
            Console.ReadKey();
        }
    }
}
