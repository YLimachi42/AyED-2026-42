using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego
{
    class Program
    {
        static void Main(string[] args)
        { // Declaración de Variables //
            Random random = new Random();
            int probabilidad;
            int vida = 10;
            int hambre = 10;
            int dia = 1;
            int ComidaCruda = 0;
            int ComidaCocida = 0;
            bool salir = false;
            bool arco = false;
            bool materiales = false;
            bool refugio = false;
            bool FogataEncendida = false;
            bool valido = true;

            Console.WriteLine("~~~ Bienvenido a Supervivencia en la Isla ~~~\n");
            Console.WriteLine("En este juego trataras de sobrevivir por 10 días en una isla con recursos limitados y tomando deciciones en todo momento las cuales pueden definir si vives o mueres.");
            Console.WriteLine("\nPulse una tecla para iniciar.");
            Console.ReadKey();
            Console.Clear();

            while (salir == false)
            {
                Console.WriteLine($"Día {dia}...\n");
                Console.WriteLine($"Cantidad de vida: {vida}\nHambre: {hambre}\n");
                Console.WriteLine("¿Que haces?\n");
                Console.WriteLine("1_Buscar Comida \n2_Explorar la isla \n3_Construir refugio \n4_Encender fogata \n5_Cocinar comida \n6_Comer comida cocida \n7_Descansar\n8_Inventario\n\n9_Salir del Juego");
                Console.Write("\nElijo: ");
                int decicion = int.Parse(Console.ReadLine());
                if (hambre == 0) { vida -= 2; }
                switch (decicion)
                {
                    case 1:
                        int chances = 60;
                        if (arco == true)
                        {
                            chances = 80;
                        }
                        probabilidad = random.Next(1, 100);
                        if (probabilidad <= chances)
                        {
                            Console.WriteLine("La busqueda resultó exitosa pero te cansaste demasiado.\nCantidad de comida cruda +2\nVida -1\nHambre -2");
                            ComidaCruda = ComidaCruda + 2;
                            vida -= 1;
                        }
                        else if (probabilidad >= chances + 1 && probabilidad <= 100)
                        {
                            Console.WriteLine("Pasaste todo el día buscando comida, pero no encontraste nada\nVida -1\nHambre -2");
                            vida -= 1;
                        }
                        Console.WriteLine("\nPresione una tecla para continuar.");
                        Console.ReadKey();
                        dia += 1;
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Exploras la isla en busca de materiales");
                        probabilidad = random.Next(1, 100);
                        if (probabilidad >= 1 && probabilidad <= 50)
                        {
                            if (materiales == false)
                            {
                                materiales = true;
                                Console.WriteLine("Has recogido muchos materiales, ahora podras construir un refugio.\nHambre -2");
                            }
                            else
                            {
                                Console.WriteLine("No has encontrado ningun material útil\nHambre -2");
                            }
                            if (!arco)
                            {
                                probabilidad = random.Next(1, 100);
                                if (probabilidad <= 20)
                                {
                                Console.WriteLine("¡Has tenido suerte! Encontraste un arco primitivo, andá a saber como llegó aca.\nSupongo que será mas facil encontrar comida...");
                                arco = true;
                                }
                            
                            }
                        }
                        else if (probabilidad >= 51 && probabilidad <= 80)
                        {
                            Console.WriteLine("Diste vueltas por toda la isla, pero no has encontrado nada.\nHambre -2");
                        }
                        else
                        {
                            Console.WriteLine("Buscando por la isla te tropezaste y caíste sobre unas rocas.\nVida -2\nHambre -2");
                            vida -= 2;
                        }
                        Console.WriteLine("\nPresione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        if (refugio == false)
                        {
                            if (materiales == true)
                            {
                                Console.WriteLine("Has construido un refugio, ahora el día pasara mas tranquilo, pero te esforzaste todo el día.\nCantidad de hambre -3");
                                refugio = true;
                                hambre -= 1;
                            }
                            else
                            {
                                Console.WriteLine("No tienes los materiales para construir un refugio, explora la isla para encontrar algo útil.");
                                valido = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya tienes un refugio construido, no hace falta otro.");
                            valido = false;
                        }
                        Console.WriteLine("\nPresione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        if (!FogataEncendida)
                        {
                            Console.WriteLine("Decidiste encender una fogata.");
                            if (refugio == true)
                            {
                                Console.WriteLine("Ahora prodras cocinar la carne cruda.\nHambre -2");
                                FogataEncendida = true;
                            }
                            else
                            {
                                Console.WriteLine("Necesitas tener un refugio para poder hacer una fogata.");
                                valido = false;
                            }
                        }
                        else { Console.WriteLine("Ya tienes una fogata encendida."); valido = false; }
                        Console.WriteLine("\nPresione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        if (FogataEncendida)
                        {
                            if (ComidaCruda > 0)
                            {
                                Console.Write("Has cocinado 1 de comida.\nHambre -2\nComida cruda -1\nComida cocida +1");
                                ComidaCruda -= 1;
                                ComidaCocida += 1;
                            }
                            else
                            {
                                Console.WriteLine("Necesitas tener comida cruda para poder cocinarla.");
                                valido = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Necesitas tener una fogata para poder cocinar la comida.");
                            valido = false;
                        }
                        Console.WriteLine("\nPresione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        if (ComidaCocida > 0)
                        {
                            Console.WriteLine("Has consumido 1 de comida cocida.\nHambre +4\nComida cocida -1");
                            ComidaCocida -= 1;
                            hambre += 6;
                        }
                        else
                        {
                            Console.WriteLine("Necesitas tener al menos 1 de comida cocida para comer");
                            valido = false;
                        }
                        Console.WriteLine("\nPresione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Decides descansar para poder recuperarte.");
                        if (refugio)
                        {
                            Console.WriteLine("La comodidad del refugio te garantiza un buen descanso.\nVida +3");
                            vida += 3;
                        }
                        else
                        {
                            Console.WriteLine("Aun no cuentas con un refugio, pero el suelo de la isla no es muy incomodo.\nVida +1");
                            vida += 1;
                        }
                        if (vida > 10) { vida = 10; }
                        Console.WriteLine("\nPresione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine($"Vida {vida}/10 | Hambre {hambre}/10\n");
                        Console.WriteLine($"Comida cruda: {ComidaCruda}\nComida cocida: {ComidaCocida}");
                        if (arco) { Console.WriteLine("Arco primitivo"); }
                        if (refugio) { Console.WriteLine("Refugio no construido."); }
                        else { Console.WriteLine("Refugio ya construido."); }
                        if (FogataEncendida) { Console.WriteLine("La fogata está encendida."); }
                        else { Console.WriteLine("No tienes una fogata encendida."); }
                        valido = false;
                        Console.WriteLine("\nPresione una tecla para regresar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        salir = true;
                        break;
                            

                    default:
                        Console.Clear();
                        Console.WriteLine("Introduzca una opción válida.");
                        valido = false;
                        break;
                }
                if (hambre < 0) { hambre = 0; }
                if (hambre > 10) { hambre = 10; }
                if (valido) { dia += 1; hambre -= 2; }
                else { valido = true; }
                if (vida <= 0)
                {
                    salir = true;
                    Console.Clear();
                    Console.WriteLine("¡Qué mala suerte!\n");
                    Console.WriteLine("Te quedaste sin vida, mas suerte la próxima...");
                    Console.WriteLine("\nPresione una tecla para continuar.");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            Console.WriteLine("¡Gracias por jugar!\n");
            Console.WriteLine("Espero que lo hayas pasado bien.");
            Console.WriteLine($"\nHas sobrevivido {dia} días en la isla, espero que sean mas la próxima vez.");

            Console.ReadKey();
        }
    }
}
