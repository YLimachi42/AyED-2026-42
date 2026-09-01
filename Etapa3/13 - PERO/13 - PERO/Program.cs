using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___PERO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int opcion;
            int cantidadMisiones = 0;
            int[,] misiones = new int[30, 5];

            do
            {
                Console.Clear();
                Console.WriteLine("==== P.E.R.O ====");
                Console.WriteLine("1. Registrar nueva misión");
                Console.WriteLine("2. Ver todas las misiones");
                Console.WriteLine("3. Cambiar estado de una misión");
                Console.WriteLine("4. Listar misiones en curso");
                Console.WriteLine("5. Misión con más objetos a extraer");
                Console.WriteLine("6. Promedio de peligro por mapa");
                Console.WriteLine("7. Filtrar por mapa");
                Console.WriteLine("8. Salir");
                Console.Write("\nElija una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        // Punto 1: Registrar nueva misión
                        if (cantidadMisiones <= 30)
                        {
                            misiones[cantidadMisiones, 0] = cantidadMisiones + 1;
                            Console.Write("1_Hagwarts\n2_La casa del viejo\n3_El laboratorio\nIngrese el mapa para explorar: ");
                            misiones[cantidadMisiones, 1] = int.Parse(Console.ReadLine());
                            misiones[cantidadMisiones, 2] = rand.Next(1, 3);
                            Console.Write("1_Bajo\n2_Medio\n3_Alto\n4_Imposible\n5_Muerte Segura\nIngrese el nivel de peligro: ");
                            misiones[cantidadMisiones, 3] = int.Parse(Console.ReadLine());
                            misiones[cantidadMisiones, 4] = 0;
                            cantidadMisiones += 1;
                            Console.WriteLine("\n¡Misión cargada con éxito!");
                        }
                        else { Console.WriteLine("¡Demasiada Misiones!"); }
                        
                        break;
                    case 2:
                        // Punto 2: Ver todas las misiones
                        Console.WriteLine("===== MISIONES CARGADAS =====\n");
                        for (int x = 0; x < cantidadMisiones; x++)
                        {
                            Console.Write("ID: " + misiones[x, 0]);
                            for (int y = 0; y < 5; y++)
                            {
                                if (y == 1)
                                {
                                    switch (misiones[x, y])
                                    {
                                        case 1:
                                            Console.Write(" - Mapa: Hagwarts");
                                            break;
                                        case 2:
                                            Console.Write(" - Mapa: La casa del viejo");
                                            break;
                                        case 3:
                                            Console.Write(" - Mapa: El laboratorio");
                                            break;
                                    }
                                }
                                if (y == 2)
                                {
                                    Console.Write($" - Cantidad de objetos: {misiones[x, y]}");
                                }
                                if (y == 3)
                                {
                                    switch (misiones[x, y])
                                    {
                                        case 1:
                                            Console.Write(" - Peligro: bajo");
                                            break;
                                        case 2:
                                            Console.Write(" - Peligro: medio");
                                            break;
                                        case 3:
                                            Console.Write(" - Peligro: alto");
                                            break;
                                        case 4:
                                            Console.Write(" - Peligro: imposible");
                                            break;
                                        case 5:
                                            Console.Write(" - Peligro: muerte segura");
                                            break;
                                    }
                                }
                                if (y == 4)
                                {
                                    switch (misiones[x, y])
                                    {
                                        case 0:
                                            Console.WriteLine(" - Estado: Pendiente");
                                            break;
                                        case 1:
                                            Console.WriteLine(" - Estado: En proceso");
                                            break;
                                        case 2:
                                            Console.WriteLine(" - Estado: Finalizado");
                                            break;
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        // Punto 3: Cambiar estado de misión
                        Console.Write("Introduzca el ID de la misión que quiera actualizar: ");
                        int indice = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine($"Estado de mision {indice + 1} actualizado");
                        if (misiones[indice, 4] == 0) { Console.WriteLine("Cambio de estado de Pendiente a En Proceso"); }
                        else if (misiones[indice, 4] == 1) { Console.WriteLine("Cambio de estado de Pendiente a En Proceso"); }
                        if (misiones[indice, 4] < 2) { misiones[indice, 4] += 1; }
                        break;
                    case 4:
                        // Punto 4: Listar misiones en curso
                        Console.WriteLine("===== MISIONES EN PROCESO =====\n");
                        for (int x = 0; x < cantidadMisiones; x++)
                        {
                            if (misiones[x, 4] == 1) { Console.Write("ID: " + misiones[x, 0]); }
                            for (int y = 0; y < 5; y++)
                            {
                                if (misiones[x, 4] == 1)
                                {
                                    if (y == 1)
                                    {
                                        switch (misiones[x, y])
                                        {
                                            case 1:
                                                Console.Write(" - Mapa: Hagwarts");
                                                break;
                                            case 2:
                                                Console.Write(" - Mapa: La casa del viejo");
                                                break;
                                            case 3:
                                                Console.Write(" - Mapa: El laboratorio");
                                                break;
                                        }
                                    }
                                    if (y == 2)
                                    {
                                        Console.Write($" - Cantidad de objetos: {misiones[x, y]}");
                                    }
                                    if (y == 3)
                                    {
                                        switch (misiones[x, y])
                                        {
                                            case 1:
                                                Console.Write(" - Peligro: bajo");
                                                break;
                                            case 2:
                                                Console.Write(" - Peligro: medio");
                                                break;
                                            case 3:
                                                Console.Write(" - Peligro: alto");
                                                break;
                                            case 4:
                                                Console.Write(" - Peligro: imposible");
                                                break;
                                            case 5:
                                                Console.Write(" - Peligro: muerte segura");
                                                break;
                                        }
                                    }
                                    if (y == 4)
                                    {
                                        Console.WriteLine(" - Estado: En proceso");
                                    }
                                }
                            }
                        }
                        break;
                    case 5:
                        // Punto 5: Misión con más objetos a extraer
                        int masObjetos = 0;
                        for (int y = 0; y < cantidadMisiones - 1; y++)
                        {
                            if (masObjetos < misiones[y, 2])
                            {
                                masObjetos = misiones[y, 2];
                            }
                            
                        }
                        Console.WriteLine($"La mision/es con más objetos es:");
                        for (int y = 0; y < cantidadMisiones; y++)
                        {
                            if (masObjetos == misiones[y, 2])
                            {
                                Console.WriteLine($"ID: {misiones[y, 0]} con {masObjetos} objetos");
                            }
                        }
                        break;
                    case 6:
                        // Punto 6: Promedio de peligro por mapa
                        int cantidadMapa1 = 0, promedioMapa1 = 0, cantidadMapa2 = 0, promedioMapa2 = 0, cantidadMapa3 = 0, promedioMapa3 = 0;
                        for (int x = 0; x < cantidadMisiones; x++)
                        {
                            if (misiones[x, 1] == 1)
                            {
                                cantidadMapa1++;
                                promedioMapa1 += misiones[x, 3];
                            }
                            if (misiones[x, 1] == 2)
                            {
                                cantidadMapa2++;
                                promedioMapa2 += misiones[x, 3];
                            }
                            if (misiones[x, 1] == 3)
                            {
                                cantidadMapa3++;
                                promedioMapa3 += misiones[x, 3];
                            }
                        }
                        int promedio1 = promedioMapa1 / cantidadMapa1;
                        int promedio2 = promedioMapa2 / cantidadMapa2;
                        int promedio3 = promedioMapa3 / cantidadMapa3;
                        Console.Write("Promedio Hagwarts: " + promedio1);
                        Console.Write("Promedio La Casa Del Viejo: " + promedio2);
                        Console.Write("Promedio El Laboratorio: " + promedio3);
                        break;
                    case 7:
                        // Punto 7: Filtrar por mapa
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Esperemos que el PERO no sea letal!");
                break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);
        }
    }
}
                