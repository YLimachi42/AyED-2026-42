using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Calculando
{
    class Program
    {
        static int Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        static int Restar(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        static int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        static int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }

        static int Calculadora(int opc)
        {
            Console.Write("Ingresar numero 1: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar numero 2: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = 0;
            switch (opc)
            {
                case 1:
                    resultado = Sumar(numero1, numero2);
                    break;
                case 2:
                    resultado = Restar(numero1, numero2);
                    break;
                case 3:
                    resultado = Multiplicar(numero1, numero2);
                    break;
                case 4:
                    resultado = Dividir(numero1, numero2);
                    break;
            }
            return resultado;
        }

        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Que Operación quiere realizar?\n");
                Console.WriteLine("1_Sumar\n2_Restar\n3_Multiplicar\n4_Dividir\n5_Salir");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opcion != 5)
                {
                    Console.Write($"El resultado es: {Calculadora(opcion)}");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }
            while (opcion != 5);
        }
    }
}