using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___ElEterNota
{
    class Program
    {
        //Falta: Establecer limites (ej: admitir solo numeros mayores o iguales a 0)
        //Mensajes aclaratorios en caso de que ningun refugio cumpla con la condicion
        //Aclarar si hay mas de un refugio con mas recursos
        //Advertir que solo se pueden ocupar refugios libres
        static void Main(string[] args)
        {
            bool valido = true;
            int[,] refugios = new int[20, 5];
            int cantidadRefugios = 0;
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
                Console.WriteLine("1. Agregar refugio");
                Console.WriteLine("2. Mostrar todos los refugios");
                Console.WriteLine("3. Ocupar refugio");
                Console.WriteLine("4. Mostrar ocupados");
                Console.WriteLine("5. Refugio con más suministros");
                Console.WriteLine("6. Promedio por zona");
                Console.WriteLine("7. Filtrar por zona");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        // Lógica para agregar refugio
                        refugios[cantidadRefugios, 0] = cantidadRefugios + 1;
                        Console.Write("Ingrese la cantidad de personas que puede alojar: ");
                        refugios[cantidadRefugios, 1] = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad de suministros disponibles: ");
                        refugios[cantidadRefugios, 2] = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nE qué zona se encuentra el refugio?");
                        Console.WriteLine("1 - Norte\n2 - Sur\n3 - Oeste\n4 - Centro\n");
                        refugios[cantidadRefugios, 3] = int.Parse(Console.ReadLine());
                        Console.WriteLine("¿El refugio esta ocupado?\n1 - SI\n0 - NO\n");
                        refugios[cantidadRefugios, 4] = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nRefugio registrado correctamente.");
                        cantidadRefugios++;
                        break;
                    case 2:
                        // Lógica para mostrar todos los refugios
                        Console.WriteLine("=== LISTA DE REFUGIOS ===\n");
                        for (int x = 0; x < cantidadRefugios; x++)
                        {
                            Console.Write($"ID: {refugios[x, 0]} || Capacidad: {refugios[x, 1]} || Suministros: {refugios[x, 2]} || ");
                            if (refugios[x, 3] == 1) { Console.Write("Zona: Norte (Congreso)"); }
                            if (refugios[x, 3] == 2) { Console.Write("Zona: Sur (Constitución)"); }
                            if (refugios[x, 3] == 3) { Console.Write("Zona: Oeste (Flores)"); }
                            if (refugios[x, 3] == 4) { Console.Write("Zona: Centro (Microcentro)"); }
                            if (refugios[x, 4] == 1) { Console.WriteLine("|| Estado: Ocupado"); }
                            else { Console.WriteLine(" || Estado: Libre"); }
                        }
                        
                        break;
                    case 3:
                        // Lógica para ocupar refugio
                        Console.WriteLine("=== LISTA DE REFUGIOS LIBRES ===\n");
                        for (int x = 0; x < cantidadRefugios; x++)
                        {
                            if (refugios[x, 4] == 0)
                            {
                                Console.Write($"ID: {refugios[x, 0]} || Capacidad: {refugios[x, 1]} || Suministros: {refugios[x, 2]} || ");
                                if (refugios[x, 3] == 1) { Console.Write("Zona: Norte (Congreso)"); }
                                if (refugios[x, 3] == 2) { Console.Write("Zona: Sur (Constitución)"); }
                                if (refugios[x, 3] == 3) { Console.Write("Zona: Oeste (Flores)"); }
                                if (refugios[x, 3] == 4) { Console.Write("Zona: Centro (Microcentro)"); }
                                Console.WriteLine(" || Estado: Libre");
                            }
                            Console.Write("\nIngrese el ID del refugio a ocupar: ");
                            int refugioOcupando = int.Parse(Console.ReadLine());
                            for (int z = 0; z < cantidadRefugios; z++)
                            {
                                if (refugios[z, 0] == refugioOcupando)
                                {
                                    refugios[z, 4] = 1;
                                }
                            }
                        }
                        break;
                    case 4:
                        // Lógica para mostrar ocupados
                        Console.WriteLine("=== LISTA DE REFUGIOS LIBRES ===\n");
                        for (int x = 0; x < cantidadRefugios; x++)
                        {
                            if (refugios[x, 4] == 1)
                            {
                                Console.Write($"ID: {refugios[x, 0]} || Capacidad: {refugios[x, 1]} || Suministros: {refugios[x, 2]} || ");
                                if (refugios[x, 3] == 1) { Console.Write("Zona: Norte (Congreso)"); }
                                if (refugios[x, 3] == 2) { Console.Write("Zona: Sur (Constitución)"); }
                                if (refugios[x, 3] == 3) { Console.Write("Zona: Oeste (Flores)"); }
                                if (refugios[x, 3] == 4) { Console.Write("Zona: Centro (Microcentro)"); }
                                Console.WriteLine(" || Estado: Ocupado");
                            }
                        }
                        break;
                    case 5:
                        // Lógica para refugio con más suministros
                        int masRecursos = refugios[0, 2];
                        for (int x = 0; x < cantidadRefugios; x++)
                        {
                            if(refugios[x, 2] > masRecursos) { masRecursos = refugios[x, 2]; }
                        }
                        Console.WriteLine("=== REFUGIO/OS CON MAS RECURSOS ===\n");
                        for (int x = 0; x < cantidadRefugios; x++)
                        {
                            if (refugios[x, 2] == masRecursos)
                            {
                                Console.Write($"ID: {refugios[x, 0]} || Capacidad: {refugios[x, 1]} || Suministros: {refugios[x, 2]} || ");
                                if (refugios[x, 3] == 1) { Console.Write("Zona: Norte (Congreso)"); }
                                if (refugios[x, 3] == 2) { Console.Write("Zona: Sur (Constitución)"); }
                                if (refugios[x, 3] == 3) { Console.Write("Zona: Oeste (Flores)"); }
                                if (refugios[x, 3] == 4) { Console.Write("Zona: Centro (Microcentro)"); }
                                if (refugios[x, 4] == 1) { Console.WriteLine("Estado: Ocupado"); }
                                else { Console.WriteLine(" || Estado: Libre"); }
                            }
                        }
                        break;
                    case 6:
                        // Lógica para promedio por zona
                        int sumaCapacidadNorte = 0, cantidadNorte = 0;
                        int sumaCapacidadSur = 0, cantidadSur = 0;
                        int sumaCapacidadOeste = 0, cantidadOeste = 0;
                        int sumaCapacidadCentro = 0, cantidadCentro = 0;
                        for (int x = 0; x < cantidadRefugios; x++)
                        {
                            if(refugios[x, 3] == 1) { sumaCapacidadNorte += refugios[x, 1]; cantidadNorte++; }
                            else if(refugios[x, 3] == 2) { sumaCapacidadSur += refugios[x, 1]; cantidadSur++; }
                            else if(refugios[x, 3] == 3) { sumaCapacidadOeste += refugios[x, 1]; cantidadOeste++; }
                            else if(refugios[x, 3] == 4) { sumaCapacidadCentro += refugios[x, 1]; cantidadCentro++; }
                        }
                        if (sumaCapacidadNorte > 0) { Console.WriteLine($"Capacidad promedio Norte: {sumaCapacidadNorte / cantidadNorte}"); }
                        if (sumaCapacidadSur > 0) { Console.WriteLine($"Capacidad promedio Sur: {sumaCapacidadSur / cantidadSur}"); }
                        if (sumaCapacidadOeste > 0) { Console.WriteLine($"Capacidad promedio Oeste: {sumaCapacidadOeste / cantidadOeste}"); }
                        if (sumaCapacidadCentro > 0) { Console.WriteLine($"Capacidad promedio Centro: {sumaCapacidadCentro / cantidadCentro}"); }
                        break;
                    case 7:
                        // Lógica para filtrar por zona
                        Console.WriteLine("1 - Norte\n2 - Sur\n3 - Oeste\n4 - Centro");
                        Console.Write("Ingrese una zona: ");
                        int zona = int.Parse(Console.ReadLine());
                        for (int x = 0; x < cantidadRefugios; x++)
                        {
                            if (refugios[x, 3] == zona)
                            {
                                Console.Write($"ID: {refugios[x, 0]} || Capacidad: {refugios[x, 1]} || Suministros: {refugios[x, 2]} || ");
                                if (refugios[x, 3] == 1) { Console.Write("Zona: Norte (Congreso)"); }
                                if (refugios[x, 3] == 2) { Console.Write("Zona: Sur (Constitución)"); }
                                if (refugios[x, 3] == 3) { Console.Write("Zona: Oeste (Flores)"); }
                                if (refugios[x, 3] == 4) { Console.Write("Zona: Centro (Microcentro)"); }
                                if (refugios[x, 4] == 1) { Console.WriteLine("|| Estado: Ocupado"); }
                                else { Console.WriteLine(" || Estado: Libre"); }
                            }
                        }
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);
            Console.ReadKey();
        }
        
    }
}
