using System;

namespace Actividad4_1030021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Actividad 4 realizada nuevamente");

            // Decidi volver a realizar la actividad tras haber investigado como simplificarme y poder aplicar el "for" al programa

            string _palabra;
            int p;

            for (p = 0; p < 11; p++)
            {

                Console.WriteLine("Ingrese una palabra");

                _palabra = Console.ReadLine();

                string aceptar = _palabra.ToUpper();

                if(_palabra == aceptar)
                {
                    Console.WriteLine("La palabra ingresada es una palabra molesta");

                    if (_palabra.Contains("!"))
                    {
                        Console.WriteLine("");

                    }
                }
                // No supe como colocar la condicion junta sin utilizar && u // como se indico en clase entonces decidi dejar la solucion
                // con un espacio domo se muestra al ejecutarlo. Y asi si podria aceptar el mismo ambas condiciones
               

                else if(_palabra != aceptar )
                    {
                        Console.WriteLine("La palabra ingresada no es una palabra molesta");
                    }
                    
                


            }
        }
    }
}

   
