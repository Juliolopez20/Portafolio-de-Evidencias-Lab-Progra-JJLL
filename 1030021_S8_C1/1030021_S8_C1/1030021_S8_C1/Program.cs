using System;

namespace _1030021_S8_C1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio de Programacion teoria 2");

            /* Enunciado:
             * Crear un programa para ir al cine que evalue edad de un a persona y sepa si
             * - Si es menor de 10 anios su entrada es gratis 
             * -si es mayor a 10 y menor de 15 su entrada vale Q.15.00
             * -Si es mayor de 15 y menor de 21 su entrada vale Q 25.00
             * -Si es mayor de 21 su entrada vale Q.35.00
             * -Si es de la tercera edad entrada gratis
             * -Si es mayor de 10 y menor de 15 puede ver PG13 y puede ver PG15 si esta con un adulto
             * -Si es mayor de 15 puede ver PG15
             * -Si es mayor de 21 puede ver todas
             * -Si es de la tercera edad ver todas
             */



            //Variables: edad, precio, clasificacion

            int precio = 0;
            int edad = 0;
            string clasificacion= "";
            string adulto = "";

            Console.WriteLine("======BIENVENIDO AL CINE======");
            Console.WriteLine("Ingrese edad: ");
            edad = Convert.ToInt32(Console.ReadLine());


            if (edad <10)
            {
                Console.WriteLine("El costo de la entrada es de Q.0.00");

            }
            else
            {
                if(edad >= 10 && edad<= 15)
                {
                    Console.WriteLine("Estas acompaniado de un adulto? (Si/No)");
                    adulto = Console.ReadLine().ToString();

                    if (adulto.ToLower()== "si" )
                    {
                        clasificacion = "PG15";
                    }
                    else
                    {
                        clasificacion = "PG13";
                    }

                    precio = 15;
                    Console.WriteLine("El costo de la entrada es " + precio + " y la clasificacion es " + clasificacion );


                }

                if (edad >=15 && edad <= 21)
                {
                    precio = 25;
                    clasificacion = "PG15";
                    Console.Write("El costo de la entrada es de " + precio + " y puede entrar a peliculas con clasificacion " + clasificacion );


                }
               if(edad > 21 && edad <=60)
                {
                    precio = 35;
                   

                    Console.WriteLine("El costo del boleto es de "+ precio+ " y puede acceder a todas las clasificaciones" );
                }

               if (edad > 60)
                {
                    
                    Console.WriteLine("El costo del boleto es Q.0.00 y puede acceder a todas las clasificaciones");
                }

            }

            



        } 
    }
}
