using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== MINI BALATRO ===");
        Console.WriteLine();
        // Generar una mano aleatoria de 5 cartas
        string[] mano = GenerarManoAleatoria();
        
        
        // Analizar que tipo de mano se obtuvo
        string tipo = TipoDeMano(mano);

        // Calcular el valor de las cartas
        int basePts = PuntajeBase(mano);

        // Obtener el multiplicador de la jugada
        double mult = Multiplicador(tipo);

        // Calcular puntaje antes de Jokers
        double total = basePts * mult;


        // Jokers disponibles
        bool jokerX2 = true;
        bool jokerMas10 = true;
        
        // Aplicar los efectos de los Jokers
        total = AplicarJokers(total, jokerX2, jokerMas10);
        
        // Mostrar el resultado
        MostrarResumen(mano, tipo, basePts, mult, total);
    }
    // ====================================================
    // CREAR TODAS LAS FUNCIONES NECESARIAS DEBAJO DEL MAIN
    // ====================================================
    static string[] GenerarManoAleatoria()
    {
        Random rnd = new Random();
        string[] manopla = new string[5];
        
        for (int x = 0; x < manopla.Length; x++)
        {
            int rango = rnd.Next(2, 15);
            int palo = rnd.Next(1, 5);
            string carta = "";
            switch (rango)
            {
                case 10:
                    carta += "T";
                    break;
                case 11:
                    carta += "J";
                    break;
                case 12:
                    carta += "Q";
                    break;
                case 13:
                    carta += "K";
                    break;
                case 14:
                    carta += "A";
                    break;
                default:
                    carta += rango.ToString();
                    break;
            }
            switch (palo)
            {
                case 1:
                    carta += "H";
                    break;
                case 2:
                    carta += "D";
                    break;
                case 3:
                    carta += "C";
                    break;
                case 4:
                    carta += "S";
                    break;
            }
            manopla[x] = carta;
            
        }
        return manopla;
    }
    static string TipoDeMano(string[] mano)
    {
        int[] repeticiones = new int[5];

        for (int i = 0; i < mano.Length; i++)
        {
            int contador = 0;

            for (int j = 0; j < mano.Length; j++)
            {
                if (mano[i][0] == mano[j][0])
                {
                    contador++;
                }
            }

            repeticiones[i] = contador;
        }

        bool tienePoker = false;
        bool tieneTrio = false;
        int cantidadPares = 0;

        for (int i = 0; i < repeticiones.Length; i++)
        {
            if (repeticiones[i] == 4)
            {
                tienePoker = true;
            }

            if (repeticiones[i] == 3)
            {
                tieneTrio = true;
            }

            if (repeticiones[i] == 2)
            {
                cantidadPares++;
            }
        }

        if (tienePoker)
        {
            return "Poker";
        }

        if (tieneTrio && cantidadPares >= 2)
        {
            return "Full";
        }

        if (tieneTrio)
        {
            return "Trio";
        }

        if (cantidadPares >= 2)
        {
            return "Par";
        }

        return "Nada";
    }
    static int PuntajeBase(string[] mano)
    {
        int puntaje = 0;
        for (int x = 0; x < mano.Length; x++)
        {
            switch (mano[x][0])
            {
                case 'A':
                    puntaje += 14;
                    break;
                case 'K':
                    puntaje += 13;
                    break;
                case 'Q':
                    puntaje += 12;
                    break;
                case 'J':
                    puntaje += 11;
                    break;
                case 'T':
                    puntaje += 10;
                    break;
                default:
                    puntaje += int.Parse(mano[x][0].ToString());
                    break;
            }
        }
        return puntaje;
    }
    static double Multiplicador(string tipo)
    {
        double multiplicador = 0;
        switch (tipo)
        {
            case "Nada":
                multiplicador = 1.0;
                break;
            case "Par":
                multiplicador = 1.5;
                break;
            case "Trio":
                multiplicador = 2.5;
                break;
            case "Full":
                multiplicador = 3.5;
                break;
            case "Poker":
                multiplicador = 4.0;
                break;
        }
        return multiplicador;
    }
    static double AplicarJokers(double total, bool x2, bool Mas10)
    {
        Console.Write("Joker x2: ");
        if (x2) { total = total * 2; Console.WriteLine("SI"); }
        else { Console.WriteLine("NO"); }
        Console.Write("Joker mas 10: ");
        if (Mas10) { total += 10; Console.WriteLine("SI"); }
        else { Console.WriteLine("NO"); }
        return total;
    }
    static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
    {
        Console.Write("Mano: ");
        for (int x = 0; x < mano.Length; x++)
        {
            Console.Write($"{mano[x]} ");
        }
        Console.WriteLine($"\nTipo de mano: {tipo}");
        Console.WriteLine($"Puntaje base: {basePts}");
        Console.WriteLine($"Multiplicador: {mult}");
        Console.WriteLine($"Puntaje final: {total}");
        Console.ReadKey();
    }

}