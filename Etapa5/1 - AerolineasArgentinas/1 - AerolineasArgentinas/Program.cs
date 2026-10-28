using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___AerolineasArgentinas
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] pasajes = new object[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine($"Número de pasaje: {x + 1}");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Destino: ");
                string destino = Console.ReadLine();
                Console.Write("Precio de asiento: ");
                int precio = int.Parse(Console.ReadLine());
                Console.Write("Cantidad de asientos: ");
                int asientos = int.Parse(Console.ReadLine());
                Pasaje xd = new Pasaje(x + 1, nombre, destino, precio, asientos);
            }
            Console.ReadKey();
            //for (int y = 0; y < pasajes.Length; )
        }
    }

    class Pasaje
    {
        private int identificador;
        private string nombrePasajero;
        private string destino;
        private int precio;
        private int asientosAdquiridos;

        public int calcularImporte()
        {
            int importe = (precio * asientosAdquiridos);
            return importe;
        }

        public void mostrarInformacion()
        {
            Console.WriteLine($"Pasaje número: {identificador}");
            Console.WriteLine($"Nombre: {nombrePasajero}");
            Console.WriteLine($"Destino: {destino}");
            Console.WriteLine($"Precio por asiento: {precio}");
            Console.WriteLine($"Asientos adquiridos: {asientosAdquiridos}");
            Console.WriteLine($"Importe total: {calcularImporte()}");
        }

        public Pasaje(int identificador, string nombrePasajero, string destino, int precio, int asientosAdquiridos)
        {
            this.identificador = identificador;
            this.nombrePasajero = nombrePasajero;
            this.destino = destino;
            this.precio = precio;
            this.asientosAdquiridos = asientosAdquiridos;
        }
    }
}
