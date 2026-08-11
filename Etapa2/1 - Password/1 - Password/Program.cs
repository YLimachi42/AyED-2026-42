using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca la contraseña: ");
            String contra = "matanga";
            String usuario = Console.ReadLine();
            String usu = usuario.ToLower();
            if (usu == contra)
            {
                Console.WriteLine("La contraseña es correcta.");
            }
            else
            {
                Console.WriteLine("La contraseña es incorrecta.");
            }
            Console.ReadKey();
        }
    }
}
