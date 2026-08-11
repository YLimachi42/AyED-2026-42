using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            bool NotaValida = false;
            float CantidadTPAprobados = 0;
            float PromedioExamenes = 0;

            Console.Write("Ingrese la cantidad de TPs: ");
            int CantidadTP = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de exámenes: ");
            int CantidadExamenes = int.Parse(Console.ReadLine());
            float[] NotasExamenes = new float[CantidadExamenes];
            float[] NotasTP = new float[CantidadTP];

            for (int i = 0; i < CantidadExamenes; i++)
            {
                while (!NotaValida)
                {
                    Console.Write($"Ingrese la nota del examen {i + 1}: ");
                    int nota = int.Parse(Console.ReadLine());
                    if (nota < 11 && nota >= 0)
                    {
                        NotasExamenes[i] = nota;
                        NotaValida = true;
                    }
                    else { Console.WriteLine("Ingresá una nota válida, wachin."); }
                }
                NotaValida = false;
            }
            for (int i = 0; i < CantidadTP; i++)
            {
                while (!NotaValida)
                {
                    Console.Write($"Ingrese la nota del tp {i + 1}: ");
                    int nota = int.Parse(Console.ReadLine());
                    if (nota < 11 && nota >= 0)
                    {
                        NotasTP[i] = nota;
                        NotaValida = true;
                    }
                    else { Console.WriteLine("Ingresá una nota válida, wachin."); }
                }
                NotaValida = false;
            }
            for (int y = 0; y < CantidadExamenes; y++)
            {
                PromedioExamenes += NotasExamenes[y];
            }
            for (int y = 0; y < CantidadTP; y++)
            {
                if (NotasTP[y] >= 6) { CantidadTPAprobados += 1; }
            }
            if (PromedioExamenes / CantidadExamenes >= 6 && CantidadTPAprobados / CantidadTP >= 0.75)
            {
                Console.WriteLine("\nAprobaron la materia.");
            }
            else { Console.WriteLine("\nA diciembre muchachos."); }
            Console.ReadKey();
        }
    }
}
