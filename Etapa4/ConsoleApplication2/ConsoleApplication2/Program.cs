using System;


public static class moduloentrada

{

    public static int leerenteropositivo(string mensaje)

    {

        int numero;

        bool esvalido;


        do

        {

            Console.Write(mensaje);

            string entrada = Console.ReadLine();

            esvalido = int.TryParse(entrada, out numero);


            if (!esvalido || numero < 0)

            {

                Console.WriteLine("error: debe ingresar un numero entero mayor o igual a cero.");

            }


        } while (!esvalido || numero < 0);


        return numero;

    }

    // en este modulo pedimos ingresar un numero entero valido el cual, en caso de no cumplir lo que se pide, 

    //se pedira de nuevo que se vuelva a ingresar un numero

    public static double leerdouble(string mensaje)

    {

        double numero;

        bool esvalido;


        do

        {

            Console.Write(mensaje);

            string entrada = Console.ReadLine();

            esvalido = double.TryParse(entrada, out numero);


            if (!esvalido)

            {

                Console.WriteLine("error: debe ingresar un numero decimal valido.");

            }


        } while (!esvalido);


        return numero;

    }

}

//al igual que en el modulo anterior, deberemos de ingresar un numero decimal el cual cumpla los requisitos,

// de no ser asi, la consola nos pedira ingresar nuevamente un numero



public static class moduloestadistica

{

    public static int calcularfactorial(int n)

    {

        int resultado = 1;


        for (int i = 1; i <= n; i++)

        {

            resultado = resultado * i;

        }


        return resultado;

    }

    // aca lo que haremos sera calcular el factorial de un vector, el tamaño del vector se decidira 

    // pidiendole al usuario que lo ingrese el mismo

    public static double calcularpromedio(double[] numeros)

    {

        double suma = 0;


        for (int i = 0; i < numeros.Length; i++)

        {

            suma = suma + numeros[i];

        }


        return suma / numeros.Length;

    }

    //aca lo que se realiza es el promedio de la suma de los numeros del vector que hayamos ingresado

    //nuevamente, es el usuario quien ingresa el tamaño



    public static void obtenerlimites(double[] numeros, out double max, out double min)

    {

        max = numeros[0];

        min = numeros[0];


        for (int i = 1; i < numeros.Length; i++)

        {

            if (numeros[i] > max)

            {

                max = numeros[i];

            }


            if (numeros[i] < min)

            {

                min = numeros[i];

            }

        }

    }

}

//aca se realizara la busqueda del numero maximo y el numero minimo,

//para ello se recorrera todo el vector mientras se comparan los numeros


public static class modulogeometria

{

    public static double areacirculo(double radio)

    {

        return 3.14159 * radio * radio;

    }



    public static double areatriangulo(double basetriangulo, double altura)

    {

        return (basetriangulo * altura) / 2;

    }

}

//aca se realiza el calculo del area de un circulo o de un triangulo

public class program

{

    public static void Main(string[] args)

    {

        int opcion = 0;


        do

        {

            Console.WriteLine(" ");

            Console.WriteLine("menu de opciones");

            Console.WriteLine("1- calcular factorial");

            Console.WriteLine("2- calcular promedio de un vector");

            Console.WriteLine("3- obtener maximo y minimo de un vector");

            Console.WriteLine("4- calcular area de un circulo");

            Console.WriteLine("5- calcular area de un triangulo");

            Console.WriteLine("6- salir");


            opcion = moduloentrada.leerenteropositivo("seleccione una opcion: ");


            switch (opcion)

            {

                case 1:

                    int numfactorial = moduloentrada.leerenteropositivo("ingrese un numero: ");

                    int factorial = moduloestadistica.calcularfactorial(numfactorial);

                    Console.WriteLine("el factorial de " + numfactorial + " es: " + factorial);

                    break;


                case 2:

                    int cantidadprom = moduloentrada.leerenteropositivo("cuantos numeros desea ingresar: ");


                    if (cantidadprom > 0)

                    {

                        double[] vectorprom = new double[cantidadprom];


                        for (int i = 0; i < cantidadprom; i++)

                        {

                            vectorprom[i] = moduloentrada.leerdouble("ingrese el numero " + (i + 1) + ": ");

                        }


                        double promedio = moduloestadistica.calcularpromedio(vectorprom);

                        Console.WriteLine("el promedio es: " + promedio);

                    }

                    else

                    {

                        Console.WriteLine("la cantidad debe ser mayor a 0.");

                    }

                    break;


                case 3:

                    int cantidadlim = moduloentrada.leerenteropositivo("cuantos numeros desea ingresar: ");


                    if (cantidadlim > 0)

                    {

                        double[] vectorlim = new double[cantidadlim];


                        for (int i = 0; i < cantidadlim; i++)

                        {

                            vectorlim[i] = moduloentrada.leerdouble("ingrese el numero " + (i + 1) + ": ");

                        }


                        double maximo, minimo;

                        moduloestadistica.obtenerlimites(vectorlim, out maximo, out minimo);


                        Console.WriteLine("el valor maximo es: " + maximo);

                        Console.WriteLine("el valor minimo es: " + minimo);

                    }

                    else

                    {

                        Console.WriteLine("la cantidad debe ser mayor a 0");

                    }

                    break;


                case 4:

                    double radio = moduloentrada.leerdouble("ingrese el radio del circulo: ");

                    double areac = modulogeometria.areacirculo(radio);

                    Console.WriteLine("el area del circulo es: " + areac + " metros cuadrados");

                    break;


                case 5:

                    double baset = moduloentrada.leerdouble("ingrese la base del triangulo: ");

                    double alturat = moduloentrada.leerdouble("ingrese la altura del triangulo: ");

                    double areat = modulogeometria.areatriangulo(baset, alturat);

                    Console.WriteLine("el area del triangulo es: " + areat + " metros cuadrados");

                    break;


                case 6:

                    Console.WriteLine("saliendo del programa");

                    break;


                default:

                    Console.WriteLine("opcion no valida, intente nuevamente");

                    break;

            }


        } while (opcion != 6);

    }

}

//por ultimo, en el main principal se mostrara todo lo relacionado con textos, tanto el menu como aquellos textos que te piden ingreasar un vector