using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto a pagar: ");
            int monto = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad con la que paga: ");
            int pago = int.Parse(Console.ReadLine());

            int vuelto = pago - monto;
            Console.WriteLine("Su vuelto es de " + vuelto);
            int billetes = 0;
            int cantidad = 10000;
            
            while (vuelto >= 1)
            {
                if (vuelto >= cantidad)
                {
                    vuelto = vuelto - cantidad;
                    billetes = billetes + 1;
                }
                
                else
                {
                    if (billetes > 0)
                    {
                        Console.WriteLine("La cantidad de billetes de " + cantidad + " es: " + billetes);
                    }
                    billetes = 0;
                    if (cantidad == 10000) { cantidad = 2000; }
                    else if (cantidad == 2000) { cantidad = 1000;}
                    else if (cantidad == 1000) { cantidad = 500; }
                    else if (cantidad == 500) { cantidad = 200; }
                    else if (cantidad == 200) { cantidad = 100; }
                    else if (cantidad == 100) { cantidad = 50; }
                    else if (cantidad == 50) { cantidad = 20; }
                    else if (cantidad == 20) { cantidad = 10; }
                    else if (cantidad == 10) { cantidad = 1; }
                }
            }
            if (vuelto == 0)
            {
                Console.WriteLine("La cantidad de billetes de " + cantidad + " es: " + billetes);
            }
            else
            {
                Console.WriteLine("No tiene la suficiente cantidad para realizar el pago.");
            }
            Console.ReadKey();
        }
    }
}
