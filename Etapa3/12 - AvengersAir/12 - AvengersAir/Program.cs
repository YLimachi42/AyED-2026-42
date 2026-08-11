using System;

namespace AvengersAirBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] asientos = new string[6, 80];

            string[] nombres = new string[80];
            string[] apellidos = new string[80];
            int[] edades = new int[80];
            string[] dnis = new string[80];
            string[] nacionalidades = new string[80];
            string[] estadosOcupacion = new string[80];

            for (int i = 0; i < 80; i++)
            {
                nombres[i] = "";
            }

            int opcion = 0;

            while (opcion != 7)
            {
                Console.Clear();
                Console.WriteLine("===== AVENGERSAIR =====");
                Console.WriteLine("1 - Vender Asiento\n2 - Devolver asiento\n3 - Modificar Asiento");
                Console.WriteLine("4 - Calcular Ventas\n5 - Buscar Pasajeros por Edad\n6 - Obtener Asientos con DNI Par");
                Console.WriteLine("7 - Salir");
                Console.Write("\nElija una opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    // ---------------------------------------------------------
                    // OPCIÓN 1: VENDER ASIENTO
                    // ---------------------------------------------------------
                    case 1:
                        Console.WriteLine("=== ASIENTOS DISPONIBLES ===");
                        bool hayDisponibles = false;

                        for (int i = 0; i < 80; i++)
                        {
                            if (nombres[i] == "")
                            {
                                int numAsiento = i + 1;

                                Console.Write($"Asiento {numAsiento}: ");
                                if (numAsiento >= 1 && numAsiento <= 20)
                                {
                                    Console.Write("Primera clase - ");
                                }
                                else if (numAsiento >= 40 && numAsiento <= 43)
                                {
                                    Console.Write("Salida de emergencia - ");
                                }
                                else
                                {
                                    Console.Write("Económico - ");
                                }
                                if (numAsiento % 2 == 0) { Console.WriteLine("Ventana"); }
                                else { Console.WriteLine("Pasillo"); }
                                hayDisponibles = true;
                            }
                        }

                        if (!hayDisponibles)
                        {
                            Console.WriteLine("Lo sentimos, el vuelo está lleno.");
                        }
                        else
                        {
                            Console.Write("\nIngrese el número de asiento que desea vender: ");
                            int ubicacionAsiento = int.Parse(Console.ReadLine()) - 1;

                            if (ubicacionAsiento >= 0 && ubicacionAsiento < 80)
                            {
                                if (nombres[ubicacionAsiento] != "")
                                {
                                    Console.WriteLine("El asiento ya está ocupado.");
                                }
                                else
                                {
                                    Console.WriteLine("\n--- REGISTRO DEL PASAJERO ---");
                                    Console.Write("Nombre: ");
                                    nombres[ubicacionAsiento] = Console.ReadLine();
                                    Console.Write("Apellido: ");
                                    apellidos[ubicacionAsiento] = Console.ReadLine();
                                    Console.Write("Edad: ");
                                    edades[ubicacionAsiento] = int.Parse(Console.ReadLine());
                                    Console.Write("DNI (solo números): ");
                                    dnis[ubicacionAsiento] = Console.ReadLine();
                                    Console.Write("Nacionalidad: ");
                                    nacionalidades[ubicacionAsiento] = Console.ReadLine();
                                    Console.Write("Estado de Ocupación: ");
                                    estadosOcupacion[ubicacionAsiento] = Console.ReadLine();

                                    Console.WriteLine($"\n¡Asiento {ubicacionAsiento + 1} vendido con éxito!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Número de asiento incorrecto.");
                            }
                        }
                        break;

                    // ---------------------------------------------------------
                    // OPCIÓN 2: DEVOLVER ASIENTO
                    // ---------------------------------------------------------
                    case 2:
                        Console.Write("Ingrese el número de asiento a devolver (1-80): ");
                        int numAsientoDevuelto = int.Parse(Console.ReadLine()) - 1;

                        if (numAsientoDevuelto >= 0 && numAsientoDevuelto < 80)
                        {
                            if (nombres[numAsientoDevuelto] != "")
                            {
                                nombres[numAsientoDevuelto] = "";
                                apellidos[numAsientoDevuelto] = "";
                                edades[numAsientoDevuelto] = 0;
                                dnis[numAsientoDevuelto] = "";
                                nacionalidades[numAsientoDevuelto] = "";
                                estadosOcupacion[numAsientoDevuelto] = "";

                                Console.WriteLine($"El asiento {numAsientoDevuelto + 1}  ha sido liberado.");
                            }
                            else
                            {
                                Console.WriteLine("El asiento ya estaba libre.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número de asiento incorrecto.");
                        }
                        break;

                    // ---------------------------------------------------------
                    // OPCIÓN 3: MODIFICAR ASIENTO
                    // ---------------------------------------------------------
                    case 3:
                        Console.WriteLine("=== ASIENTOS OCUPADOS ===");
                        bool hayOcupados = false;

                        for (int i = 0; i < 80; i++)
                        {
                            if (nombres[i] != "")
                            {
                                Console.WriteLine("Asiento " + (i + 1) + " - " + nombres[i] + " " + apellidos[i]);
                                hayOcupados = true;
                            }
                        }

                        if (!hayOcupados)
                        {
                            Console.WriteLine("No hay asientos ocupados para modificar.");
                        }
                        else
                        {
                            Console.Write("\nIngrese el número de asiento a modificar: ");
                            int numAsientoSuelto = int.Parse(Console.ReadLine());
                            int i = numAsientoSuelto - 1;

                            if (i >= 0 && i < 80 && nombres[i] != "")
                            {
                                Console.WriteLine("\nIngrese los nuevos datos:");
                                Console.Write("Nuevo Nombre: "); nombres[i] = Console.ReadLine();
                                Console.Write("Nuevo Apellido: "); apellidos[i] = Console.ReadLine();
                                Console.Write("Nueva Edad: "); edades[i] = int.Parse(Console.ReadLine());
                                Console.Write("Nuevo DNI: "); dnis[i] = Console.ReadLine();
                                Console.Write("Nueva Nacionalidad: "); nacionalidades[i] = Console.ReadLine();
                                Console.Write("Nuevo Estado de Ocupación: "); estadosOcupacion[i] = Console.ReadLine();

                                Console.WriteLine("\n¡Datos actualizados con éxito!");
                            }
                            else
                            {
                                Console.WriteLine("Asiento inválido o no está ocupado.");
                            }
                        }
                        break;

                    // ---------------------------------------------------------
                    // OPCIÓN 4: CALCULAR VENTAS
                    // ---------------------------------------------------------
                    case 4:
                        int totalRecaudado = 0;

                        for (int i = 0; i < 80; i++)
                        {
                            if (nombres[i] != "")
                            {
                                int numAsiento = i + 1;

                                if (numAsiento >= 1 && numAsiento <= 20)
                                {
                                    totalRecaudado = totalRecaudado + 200;
                                }
                                else if (numAsiento >= 40 && numAsiento <= 43)
                                {
                                    totalRecaudado = totalRecaudado + 80;
                                }
                                else
                                {
                                    totalRecaudado = totalRecaudado + 100;
                                }
                            }
                        }

                        Console.WriteLine("--- RECAUDACIÓN TOTAL ---");
                        Console.WriteLine("Total recaudado en el vuelo: $" + totalRecaudado);
                        break;

                    // ---------------------------------------------------------
                    // OPCIÓN 5: BUSCAR PASAJEROS POR EDAD
                    // ---------------------------------------------------------
                    case 5:
                        Console.Write("Ingrese la edad a buscar: ");
                        int edadBuscar = int.Parse(Console.ReadLine());
                        bool encontrado = false;

                        Console.WriteLine("\nPasajeros con " + edadBuscar + " años:");
                        for (int i = 0; i < 80; i++)
                        {
                            if (nombres[i] != "" && edades[i] == edadBuscar)
                            {
                                Console.WriteLine("- Asiento " + (i + 1) + ": " + nombres[i] + " " + apellidos[i]);
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se encontraron pasajeros con esa edad.");
                        }
                        break;

                    // ---------------------------------------------------------
                    // OPCIÓN 6: OBTENER ASIENTOS CON DNI PAR
                    // ---------------------------------------------------------
                    case 6:
                        Console.WriteLine("--- ASIENTOS CON DNI PAR ---");
                        bool encontradoDni = false;

                        for (int i = 0; i < 80; i++)
                        {
                            if (nombres[i] != "")
                            {
                                long dniNumero = long.Parse(dnis[i]);

                                if (dniNumero % 2 == 0)
                                {
                                    Console.WriteLine("- Asiento " + (i + 1) + ": " + nombres[i] + " (DNI: " + dnis[i] + ")");
                                    encontradoDni = true;
                                }
                            }
                        }

                        if (!encontradoDni)
                        {
                            Console.WriteLine("No se encontraron pasajeros con DNI par.");
                        }
                        break;

                    // ---------------------------------------------------------
                    // OPCIÓN 7: SALIR
                    // ---------------------------------------------------------
                    case 7:
                        Console.WriteLine("¡Gracias por usar AvengersAir! Buen viaje.");
                        break;

                    // ---------------------------------------------------------
                    // CASO DEFECTO: OPCIÓN INCORRECTA
                    // ---------------------------------------------------------
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 7)
                {
                    Console.WriteLine("\nPresione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}