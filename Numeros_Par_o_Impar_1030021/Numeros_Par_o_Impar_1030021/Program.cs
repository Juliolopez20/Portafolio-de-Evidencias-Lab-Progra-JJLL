using System;

namespace Numeros_Par_o_Impar_1030021
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] _vector;
            int _CantidadDatos = 0;
            Console.WriteLine("Ingrese cantidad");
            _CantidadDatos = int.Parse(Console.ReadLine());

            _vector = new int[_CantidadDatos];

            for(int i=0;i<=_CantidadDatos; i++)
            {
                Console.WriteLine("Ingrese valor");

                _vector[i] = int.Parse(Console.ReadLine());


                if(_vector[i] % 2 == 0)
                {
                    Console.WriteLine(" Es par");

                }
                else
                {
                    Console.WriteLine("Es impar");

                }
                    
                     

            

            }



        }
    }
}
