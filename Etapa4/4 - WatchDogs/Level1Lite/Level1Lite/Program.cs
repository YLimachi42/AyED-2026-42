using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
        bool ok = Level1.ValidateAccessKey("WD-700000")
                  && !Level1.ValidateAccessKey("WD-123123")
                  && !Level1.ValidateAccessKey("WX-000007")
                  && !Level1.ValidateAccessKey("WD-00007");
        if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
        else Console.WriteLine("🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level1
{
    // Debe devolver true solo si:
    // - Empieza por "WD-"
    // - Luego hay exactamente 6 dígitos
    // - La suma de esos 6 dígitos es múltiplo de 7
    public static bool ValidateAccessKey(string key)
    {
        // TODO: implementar
        bool claveValida = false;
        bool soloDigitos = true;
        int sumaDigitos = 0;
        if (key.StartsWith("WD-") && key.Length == 9)
        {
            for (int x = 3; x < key.Length; x++)
            {
                if (Char.IsDigit(key[x]))
                {
                    sumaDigitos += key[x] - '0';
                }
                else { soloDigitos = false; }
            }
            if (soloDigitos)
            {
                if (sumaDigitos % 7 == 0) { claveValida = true; }
            }
        }
        return claveValida; // <- reemplazar por tu solución
    }
}