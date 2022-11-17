using System;

namespace Hojadetrabajo7_1030021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoja de Tranajo no.7");
            
            double t;
            double Celsius;

            Console.WriteLine("Ingrese la temperatura registrada");
            Solicitartemp();
                double resultado = Calculotemp(t);

                Console.WriteLine("La temperatura en grados celsius es: " + resultado.ToString ());


                void Solicitartemp()
                {
                    t = Convert.ToDouble(Console.ReadLine());
                }

                double Calculotemp(double t)
                {

                    Celsius = (t - 32) * (5 / 9);
                    return Celsius;
                }
            


        }
    }
}
