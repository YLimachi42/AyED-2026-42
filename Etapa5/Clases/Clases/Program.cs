using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa5
{
    class Mate
    {
        private int altura;
        private bool tieneBombilla;
        private int capacidad;
        private int radio;
        private string material;
        private int cantidadAgua;

        public void cebar()
        {
            cantidadAgua = capacidad;
        }
        public void tomar(int tomar)
        {
            cantidadAgua -= tomar;
        }
        public int getCantAgua()
        {
            return cantidadAgua;
        }
        public Mate(int altura, bool tieneBombilla, int capacidad, int radio, string material)
        {
            this.altura = altura;
            this.tieneBombilla = tieneBombilla;
            this.capacidad = capacidad;
            this.radio = radio;
            this.material = material;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mate mateFran = new Mate(10, true, 70, 4, "Quebraco");

            Console.WriteLine($"Cantidad de agua: {mateFran.getCantAgua()}");
            mateFran.cebar();
            Console.WriteLine($"Cantidad de agua: {mateFran.getCantAgua()}");
            mateFran.tomar(20);
            Console.WriteLine($"Cantidad de agua: {mateFran.getCantAgua()}");
            Console.ReadKey();

            Mate mateRojo = new Mate(11, false, 70, 4, "Vidrio");

            Mate mateEnanoOrejon = new Mate(5, false, 30, 2, "Aluminio");

            Mate matePatas = new Mate(8, true, 40, 2, "Aluminio");

            Mate mateCopa = new Mate(9, false, 35, 2, "Aluminio");

            Mate mateBlanco = new Mate(10, false, 60, 3, "Ceramica");

        }
    }

}