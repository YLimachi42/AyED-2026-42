using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Bienvenido al Programa -----");
            Console.WriteLine("Qué desea realizar?\n1_Sumar 2 números\n2_Restar 2 números\n3_Info del Programa\n4_Salir del Programa.\n");
            bool done = false;
            while (done == false)
            {
                Console.Write("Seleccione una opción: ");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Write("Ingrese un número entero: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        int suma = num1 + num2;
                        Console.WriteLine("La suma de los 2 numeros es: " + suma + "\n");
                        break;

                    case 2:
                        Console.Write("Ingrese un número entero: ");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int num4 = int.Parse(Console.ReadLine());
                        int resta = num3 - num4;
                        Console.WriteLine("La resta de los 2 numeros es: " + resta+"\n");
                        break;

                    case 3:
                        Console.WriteLine("El programa fué crado el 21/4/2026 por el alumno Yerik Limachi de 4° 2°\n");
                        break;
                    case 4:
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Opción invalida, vuelva a intentarlo.");
                        break;
                }
            }
        }
    }
}
