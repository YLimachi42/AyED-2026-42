using System;

    class Program
    {
        static void Main()
        {
        //es un edificio de planta baja y 4 pisos
        //departamento 2 y 3 ocupados
        //piso 1 hay uno ocupados
        //segundo piso 3 ocupados
        //cuarto piso 1 
        //cuenta con 4 departamentos por piso, tiene una ocupacion parcial, en la planta baja, el departamento 2 y 3
        //estan ocupados en el primer piso }, hay solo uno ocupado, en el segundo piso, hay 3 ocupados
        //en el tercer piso 1 ocupado y el cuarto piso 2
        //hacer un programa que muestre los lugares disponibles en formato de matriz y los ocupados, con la leyenda "ocupado"
        //el ingreso por ocupacion mensual, es de 540000 pesos, mostrar la recaudacion mensual y anual y la perdida por falta de ocupacion
        string[] departamento = new string[4];
        string[] pb = new string[4];
        string[] piso_1 = new string[4];
        string[] piso_2 = new string[4];
        string[] piso_3 = new string[4];
        string[] piso_4 = new string[4];
        int recaudacion = 0;
        int cantida_m = 540000;
        int ganancias = 0;
        int perdidas = 0;
        departamento[0] = "deparamento 1: ";
        departamento[1] = "deparamento 2: ";
        departamento[2] = "deparamento 3: ";
        departamento[3] = "deparamento 4: ";
        pb[1] = "ocupado";
        pb[2] = "ocupado";
        piso_1[2] = "ocupado";
        piso_2[0] = "ocupado";
        piso_2[1] = "ocupado";
        piso_2[2] = "ocupado";
        piso_3[2] = "ocupado";
        piso_4[3] = "ocupado";
        piso_4[1] = "ocupado";
        for(int i = 0;i<pb.Length;i++)
        {
            if (pb[i] != "ocupado")
            {
                pb[i] = "libre";
                recaudacion -= cantida_m;
                perdidas -= cantida_m;
            }
            else
            {
                recaudacion += cantida_m;
                ganancias += cantida_m;
            }
            if (piso_1[i] != "ocupado")
            {
                piso_1[i] = "libre";
                recaudacion -= cantida_m;
                perdidas -= cantida_m;
            }
            else
            {
                recaudacion += cantida_m;
                ganancias += cantida_m;
            }
            if (piso_2[i] != "ocupado")
            {
                piso_2[i] = "libre";
                recaudacion -= cantida_m;
                perdidas -= cantida_m;
            }
            else
            {
                recaudacion += cantida_m;
                ganancias += cantida_m;
            }
            if (piso_3[i] != "ocupado")
            {
                piso_3[i] = "libre";
                recaudacion -= cantida_m;
                perdidas -= cantida_m;
            }
            else
            {
                recaudacion += cantida_m;
                ganancias += cantida_m;
            }
            if (piso_4[i] != "ocupado")
            {
                piso_4[i] = "libre";
                recaudacion -= cantida_m;
                perdidas -= cantida_m;
            }
            else
            {
                recaudacion += cantida_m;
                ganancias += cantida_m;
            }
        }
        for(int j = 0; j< 5; j++)
        {
            if (j == 0)
            {
                Console.WriteLine("cuarto piso:");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
         
            }
            if (j == 1)
            {
                Console.WriteLine("tercer piso:");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            if (j == 2)
            {
                Console.WriteLine("segundo piso:");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            if (j == 3)
            {
                Console.WriteLine("primer piso:");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            if (j == 4)
            {
                Console.WriteLine("planta baja:");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            for (int i = 0; i< 4;i++)
            {
                if (j == 0)
                {
                    Console.Write(departamento[i]);
                    Console.Write(piso_4[i] + " ");
                }
                if (j == 1)
                {
                    Console.Write(departamento[i]);
                    Console.Write(piso_3[i] + " ");
                }
                if (j == 2)
                {
                    Console.Write(departamento[i]);
                    Console.Write(piso_2[i] + " ");
                }
                if (j == 3)
                {
                    Console.Write(departamento[i]);
                    Console.Write(piso_1[i] + " ");
                }
                if (j == 4)
                {
                    Console.Write(departamento[i]);
                    Console.Write(pb[i] + " ");
                }
            }
            Console.WriteLine("");
            if (j == 0)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------");

            }
            if (j == 1)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            if (j == 2)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            if (j == 3)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            if (j == 4)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            
        }
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("|recaudaciones, perdidas y ganancias mensuales|");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("el total recaudado de todo el edificio, contando ocupaciones y desocupaciones es de: " + recaudacion );
        Console.WriteLine("el total de ganancias de todo el edificio es de: " + ganancias);
        Console.WriteLine("el total de perdidas de todo el edificio es de: " + perdidas * -1);
        Console.WriteLine("y en un año estos serian las recaudaciones,ganancias,perdidas");
        Console.WriteLine("recaudaciones: " + recaudacion * 12 + " ganancias: " + ganancias * 12 + " perdidas: " + perdidas * 12 * -1);
        Console.ReadKey();
    }
    }
