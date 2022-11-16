using System;

namespace Proyectopalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Actividad 4 semana 8 1030021 JULIO LOpez ");

            string[] aPalabras = { "HOLA ", "uno", "dos", "tres ", "cuatro", "MANZANA", "carro", "PERA", "azul", "ROJO" };
            string nombre = "Ejemplo variable";

            for (int inc=0; inc<10; inc++)
            {
                Console.WriteLine("Validando mayusculas.." + aPalabras[inc]);
                if (esMayusculas(aPalabras[inc]))
                {
                    Console.WriteLine("La palabra: " + aPalabras[inc] + " es mayuscula ");
                }
            } 
        }

        static bool esMayusculas(string input)
        {
            for(int i=0; i< input.Length; i++)
            {
                if (!Char.IsUpper(input[i]))
                    return false;
            }
            return true;
        }
    }
}
