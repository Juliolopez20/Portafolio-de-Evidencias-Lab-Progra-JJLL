using System;

namespace Hoja_de_trabajo_no_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de un circulo");

            double r, pi;
            double area;

            r = 0;
            pi = 3.14;
           
            Console.WriteLine("Ingresar el valor del radio con decimales");
            SolicitarDatos();
            double resultado = calculoArea(r);
            Console.WriteLine("El valor del area es: " + resultado.ToString());

            void SolicitarDatos()
            {
                r = Convert.ToDouble(Console.ReadLine());

            }


            double calculoArea(double radio)
            {

                area = pi * Math.Pow(r, 2);
                return area;
            }

        }
    }
}