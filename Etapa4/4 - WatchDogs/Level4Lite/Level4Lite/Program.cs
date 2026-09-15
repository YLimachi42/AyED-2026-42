using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
        string msg = "ctOS";
        string enc = Level4.CaesarPlusOne(msg);
        bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
        Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level4
{
    public static string CaesarPlusOne(string s)
    {
        // TODO: implementar
        string resultado = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                if (char.IsUpper(s[i]))
                {
                    if (s[i] >= 'A' && s[i] <= 'Z') { resultado += (char)(s[i] + 1); }
                }
                else if (char.IsLower(s[i]))
                {
                    if (s[i] >= 'a' && s[i] <= 'z') { resultado += (char)(s[i] + 1); }
                }
            }
        }
        // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
        return resultado; // <- reemplazar por tu solución
    }
}