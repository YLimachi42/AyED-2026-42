using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___POO_Eternauta
{
    class Program
    {

        static void Main(string[] args)
        {
            Refugio refugio1 = new Refugio(101, 20, 12);
            Refugio refugio2 = new Refugio(102, 15, 10);
            Refugio refugio3 = new Refugio(103, 30, 25);
            refugio1.mostrarInformacion();
            refugio2.mostrarInformacion();
            refugio3.mostrarInformacion();
            Console.WriteLine("\n=== RESUMEN ===\n");
            int totalAlojadas = refugio1.getAlojadas() + refugio2.getAlojadas() + refugio3.getAlojadas();
            Console.WriteLine($"Personas alojadas: {totalAlojadas}");
            int totalDisponibles = refugio1.calcularDisponibles() + refugio2.calcularDisponibles() + refugio3.calcularDisponibles();
            Console.WriteLine($"Espacios disponibles: {totalDisponibles}");

            Refugio refugioMayor = refugio1;

            if (refugio2.getCapacidad() > refugioMayor.getCapacidad())
            {
                refugioMayor = refugio2;
            }

            if (refugio3.getCapacidad() > refugioMayor.getCapacidad())
            {
                refugioMayor = refugio3;
            }
            Console.WriteLine($"Refugio con mayor capacidad: {refugioMayor.getIdentificador()} con {refugioMayor.getCapacidad()}");
            Console.ReadKey();
        }
    }

    class Refugio
    {
        private int identificador;
        private int capacidadMaxima;
        private int cantidadAlojadas;

        public int calcularDisponibles()
        {
            int disponibles = (capacidadMaxima - cantidadAlojadas);
            return disponibles;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine($"Refugio {identificador}");
            Console.WriteLine($"Capacidad máxima: {capacidadMaxima}");
            Console.WriteLine($"Cantidad de personas alojadas: {cantidadAlojadas}");
            Console.WriteLine($"Disponibles: {calcularDisponibles()}\n");
        }
        public int getAlojadas()
        {
            return cantidadAlojadas;
        }
        public int getCapacidad()
        {
            return capacidadMaxima;
        }
        public int getIdentificador()
        {
            return identificador;
        }
        public Refugio(int identificador, int capacidadMaxima, int cantidadAlojadas)
        {
            this.identificador = identificador;
            this.capacidadMaxima = capacidadMaxima;
            this.cantidadAlojadas = cantidadAlojadas;
        }
    }
}
