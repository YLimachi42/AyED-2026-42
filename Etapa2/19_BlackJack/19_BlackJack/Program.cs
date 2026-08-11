using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡LLEGO LA TIMBA PAAAA!\n");
            Console.WriteLine("Bienvenido al Black Jack simple.\nEn este juego dependeras de tu suerte para poder ganarle al crupier, pero no seas avaricioso ¡ojo!");
            Console.Write("\nIngrese su nombre para empezar: ");
            string Nombre = Console.ReadLine();
            Console.Clear();
            /// VARIABLES ///
            Random random = new Random();
            int NumeroRandom;
            int PuntajeJugador = 0;
            int PuntajeCrupier = 0;
            int CartasPedidas = 0;
            int victorias = 0;
            int empates = 0;
            int derrotas = 0;
            bool Partida = true;
            bool Planta = false;
            bool Salir = false;

            while (Salir == false)
            {
                Console.WriteLine("===== BLACK JACK SIMPLE =====\n");
                if (PuntajeCrupier < 1) { Console.WriteLine("Puntaje del Crupier: ?"); }
                else { Console.WriteLine($"Puntaje del Crupier {PuntajeCrupier}"); }
                Console.WriteLine($"Puntaje de {Nombre}: {PuntajeJugador}\n");
                Console.WriteLine($"Cartas pedidas: {CartasPedidas}");
                Console.WriteLine("1 - Pedir una carta\n2 - Plantarse\n3 - Reglas\n4 - Salir\n");
                Console.WriteLine($"Victorias: {victorias}\nEmpates: {empates}\nDerrotas: {derrotas}.");
                Console.Write("\nSeleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        NumeroRandom = random.Next(1, 11);
                        PuntajeJugador += NumeroRandom;
                        CartasPedidas += 1;
                        Console.WriteLine($"\nSalió un {NumeroRandom}.");
                        Console.WriteLine("\nPresione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Planta = true;
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Estas son las reglas del Black Jack simple.\n");
                        Console.WriteLine("Tu puntaje inicial es 0, para ir sumando deberas pedir cartas hasta acercarte lo mas posible a 21.");
                        Console.WriteLine("Si te llegas a pasar de 21, perdiste.\nCuando estes listo y no quieras arriesgar mas, podes plantarte.");
                        Console.WriteLine("Cuando de plantas empieza a jugar el Crupier, el cual debera pedir cartas hasta superar los 17 puntos, si se llega a pasar de 21, ganaste");
                        Console.WriteLine("Pero si no se pasa de 21 pero si de 17, se planta, entonces se compararan ámbos puntajes para ver quien se acercó mas a 21, y el que lo haya hecho, gana.");
                        Console.WriteLine("Si llegan a tener el mismo puntaje, se dará un empate.");
                        Console.WriteLine("\nPresione una tecla para volver.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Salir = true;
                        break;
                }
                if (PuntajeJugador > 21)
                {
                    Console.WriteLine("=== PERDISTE ===\n");
                    Console.WriteLine($"Tu puntaje es {PuntajeJugador}, te pasaste de 21.");
                    derrotas += 1;
                    Partida = false;
                    Console.WriteLine("\nPresione para continuar.");
                    Console.ReadKey();
                }
                if (Planta == true)
                {
                    while (PuntajeCrupier < 16)
                    {
                        Console.Clear();
                        Console.WriteLine($"Puntaje de {Nombre}: {PuntajeJugador}\n");
                        Console.WriteLine($"Puntaje del Crupier {PuntajeCrupier}");
                        NumeroRandom = random.Next(1, 11);
                        PuntajeCrupier += NumeroRandom;
                        Console.WriteLine($"Salió un {NumeroRandom}.");
                        Console.WriteLine("\nPresione para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (PuntajeCrupier > 21)
                    {
                        Console.WriteLine("=== GANASTE ===\n");
                        Console.WriteLine($"El Crupier tiene {PuntajeCrupier}, se pasó de 21.");
                        victorias += 1;
                        Partida = false;
                        Console.WriteLine("\nPresione para continuar.");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (PuntajeJugador > PuntajeCrupier)
                        {
                            Console.WriteLine("=== GANASTE ===\n");
                            Console.WriteLine($"Tu puntaje es {PuntajeJugador}, más que los {PuntajeCrupier} del Crupier.");
                            victorias += 1;
                            Partida = false;
                            Console.WriteLine("\nPresione para continuar.");
                            Console.ReadKey();
                        }
                        else if (PuntajeCrupier == PuntajeJugador)
                        {
                            Console.WriteLine("=== EMPATE ===\n");
                            Console.WriteLine($"Ámbos sacaron el mismo puntaje, {PuntajeJugador}.");
                            empates += 1;
                            Partida = false;
                            Console.WriteLine("\nPresione para continuar.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("=== PERDISTE ===\n");
                            Console.WriteLine($"Tu puntaje es {PuntajeJugador}, pero el del Crupier es {PuntajeCrupier}, mas que el tuyo.");
                            derrotas += 1;
                            Partida = false;
                            Console.WriteLine("\nPresione para continuar.");
                            Console.ReadKey();
                        }
                    }
                }
                if (!Partida)
                {
                    bool reinicio = true;
                    while (reinicio)
                    {
                        Console.Clear();
                        Console.WriteLine("¿Deseas volver a jugar?\n");
                        Console.WriteLine("1 - Si\n2 - No");
                        int VolverAJugar = int.Parse(Console.ReadLine());
                        switch (VolverAJugar)
                        {
                            case 1:
                                PuntajeJugador = 0;
                                PuntajeCrupier = 0;
                                CartasPedidas = 0;
                                Partida = true;
                                Planta = false;
                                reinicio = false;
                                break;
                            case 2:
                                Salir = true;
                                reinicio = false;
                                break;
                            default:
                                Console.WriteLine("Ingrese un valor válido.");
                                break;
                        }
                    }
                    Console.Clear();
                }
            }
            Console.Clear();
            Console.WriteLine("Gracias por jugar.\n\n\n\nwachin.");
            Console.ReadKey();
        }
    }
}
