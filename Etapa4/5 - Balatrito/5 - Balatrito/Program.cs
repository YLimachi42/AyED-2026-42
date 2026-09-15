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
}