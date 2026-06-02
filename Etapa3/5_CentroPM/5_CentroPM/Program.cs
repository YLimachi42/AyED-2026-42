using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vidasPokemones = new int[6];
            int cantidad = 0;
            int debilitados = 0;
            bool salir = false;
            bool valido = true;
            Random random = new Random();

            Console.WriteLine("=== Bienvenido al centro Poké-Remedio ===\n");
            Console.WriteLine("En este centro administras la vida de los tarados de los pokemnos o qsy anda a laburar.");
            Console.ReadKey();

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("===== Centro Poké-Remedio =====\n");
                Console.WriteLine("1 - Registrar un nuevo pokémon\n2 - Mostrar la vida de todos los pokemones\n3 - Curar un pokémon");
                Console.WriteLine("4 - Dañar un pokémon\n5 - Curar todos los pokemones\n6 - Mostrar pokemones debilitados\n7 - Mostrar el pokémon con mayor vida");
                Console.WriteLine("8 - Mostrar el pokémon con menos vida\n9 - Calcular promedio de vida del equipo\n10 - Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("11 - Ordenar pokemones por vida de mayor a menor\n12 - Simular ataque enemigo a todo el equipo\n13 - Salir\n");
                Console.Write("Elijo opción: ");
                valido = true;
                int opcion = int.Parse(Console.ReadLine());
                debilitados = 0;
                switch (opcion)
                {
                    case 1:
                        if (cantidad + 1 < 7)
                        {
                            while (valido)
                            {
                                Console.Write($"Ingrese la vida del pokémon {cantidad + 1}: ");
                                int vida = int.Parse(Console.ReadLine());
                                if (vida <= 100 && vida >= 0)
                                {
                                    vidasPokemones[cantidad] = vida;
                                    valido = false;
                                }
                                else { Console.WriteLine("Ingrese un valor entre 0 y 100."); }
                            }
                            cantidad += 1;
                        }
                        else
                        {
                            Console.WriteLine("No se puede ingresar más pokemones. El centro está lleno");
                            Console.Write("\nPulse una tecla para continuar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== Pokemones Internados ===\n");
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine($"Vida pokémon {i + 1}: {vidasPokemones[i]}");
                        }
                        Console.WriteLine("\nPulse una tecla para volver.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        int pokemonCurado = 0;
                        while (valido)
                        {
                            Console.Write("Ingrese el pokémon que quiere curar: ");
                            pokemonCurado = int.Parse(Console.ReadLine());
                            if (pokemonCurado <= 6 && pokemonCurado > 0)
                            {
                                Console.Write("Cuántos puntos queres curarle: ");
                                int vida = int.Parse(Console.ReadLine());
                                vidasPokemones[pokemonCurado - 1] += vida;
                                if (vidasPokemones[pokemonCurado - 1] < 0) { vidasPokemones[pokemonCurado - 1] = 0; }
                                Console.WriteLine($"\nVida del pokémon {pokemonCurado}: {vidasPokemones[pokemonCurado - 1]}");
                                valido = false;
                            }
                            else { Console.WriteLine($"Ingrese un número entre 1 y 6"); }
                        }
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        int pokemonDañado = 0;
                        while (valido)
                        {
                            Console.Write("Ingrese el pokémon que quiere dañar: ");
                            pokemonDañado = int.Parse(Console.ReadLine());
                            if (pokemonDañado <= 6 && pokemonDañado > 0)
                            {
                                Console.Write("Cuántos puntos queres quitarle: ");
                                int daño = int.Parse(Console.ReadLine());
                                vidasPokemones[pokemonDañado - 1] -= daño;
                                if (vidasPokemones[pokemonDañado - 1] < 0) { vidasPokemones[pokemonDañado - 1] = 0; }
                                Console.WriteLine($"\nVida del pokémon {pokemonDañado}: {vidasPokemones[pokemonDañado - 1]}");
                                valido = false;
                            }
                            else { Console.WriteLine($"Ingrese un número entre 1 y 6"); }
                        }
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write("Ingrese los puntos de curación general: ");
                        int curaGeneral = int.Parse(Console.ReadLine());
                        for (int i = 0; i < cantidad; i++)
                        {
                            vidasPokemones[i] += curaGeneral;
                            if (vidasPokemones[i] > 100) { vidasPokemones[i] = 100; }
                        }
                        Console.WriteLine("Todos los pokemones fueron curados.");
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("=== Pokemones debilitados ===\n");
                        for (int i = 0; i < cantidad; i++)
                        {
                            //
                            if (vidasPokemones[i] == 0)
                            {
                                Console.WriteLine($"Pokémon {i + 1}");
                                debilitados += 1;
                            }
                            if (debilitados > 0) { Console.WriteLine($"Hay {debilitados} pokemones debilitados."); }
                            else { Console.WriteLine("No hay pokemones debilitados."); }
                        }
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        int mayorVida = vidasPokemones[0];
                        for (int y = 0; y < cantidad - 1; y++)
                        {
                            if (mayorVida < vidasPokemones[y + 1])
                            {
                                mayorVida = vidasPokemones[y + 1];
                            }
                        }
                        Console.Write("El pokémon con mas vida es: ");
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (vidasPokemones[i] == mayorVida && valido == true) { Console.WriteLine($"Pokémon {i + 1} con {mayorVida} puntos de vida."); valido = false;  break;}
                        }
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        int menorVida = vidasPokemones[0];
                        for (int x = 0; x < cantidad - 1; x++)
                        {
                            if (menorVida > vidasPokemones[x + 1])
                            {
                                menorVida = vidasPokemones[x + 1];
                            }
                        }
                        Console.Write("El pokémon con menos vida es: ");
                        for (int x = 0; x < cantidad; x++)
                        {
                            if (vidasPokemones[x] == menorVida && valido == true)
                            {
                                Console.WriteLine($"Pokémon {x + 1} con {menorVida} puntos de vida.");
                                valido = false;
                            }
                        }
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        int sumaVidas = 0;
                        for (int y = 0; y < cantidad; y++)
                        {
                            sumaVidas += vidasPokemones[y];
                        }
                        int promedio = sumaVidas / cantidad;
                        if (promedio >= 70) { Console.WriteLine("El equipo está en buen estado."); }
                        if (promedio < 70 && promedio > 31) { Console.WriteLine("El equipo necesita curación."); }
                        if (promedio <= 30) { Console.WriteLine("El equipo está en peligro."); }
                        Console.WriteLine($"Promedio de vida del equipo: {promedio}");
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 10:
                        for (int y = 0; y < cantidad; y++)
                        {
                            for (int x = 0; x < cantidad - 1; x++)
                            {
                                if (vidasPokemones[x] > vidasPokemones[x + 1])
                                {
                                    int temp = vidasPokemones[x];
                                    vidasPokemones[x] = vidasPokemones[x + 1];
                                    vidasPokemones[x + 1] = temp;
                                }
                            }
                        }
                        //Array.Sort(vidasPokemones);
                        Console.WriteLine("El equipo se ha ordenado de menor a mayor.");
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 11:
                        Array.Sort(vidasPokemones);
                        Array.Reverse(vidasPokemones);
                        Console.WriteLine("El equipo se ha ordenado de mayor a menor.");
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 12:
                        Console.WriteLine("¡un pokémon salvaje atacó a todo el equipo!");
                        int dañoPokemon = random.Next(1, 26);
                        for (int z = 0; z < cantidad; z++)
                        {
                            vidasPokemones[z] -= dañoPokemon;
                            if (vidasPokemones[z] < 0) { vidasPokemones[z] = 0; }
                        }
                        Console.WriteLine($"Daño recibido por todos: {dañoPokemon}");
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 13:
                        Console.Clear();
                        Console.WriteLine("Gracias por confiar en el centro Poké-Remedio\nNos vemos... wachin.");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción válida.");
                        Console.WriteLine("\nPulse una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
