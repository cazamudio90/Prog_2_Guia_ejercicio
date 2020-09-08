using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");

            int v_aux_number;
            int number_cuadrado;
            int number_cubo;
            string respuesta;
            
            Console.WriteLine("Ingrese un numero");
            respuesta = Console.ReadLine();

            if (int.TryParse(respuesta, out v_aux_number) )
            {
                if (v_aux_number > 0 )
                {
                    number_cuadrado = (int)Math.Pow(v_aux_number,2);
                    number_cubo = (int)Math.Pow(v_aux_number, 3);

                    Console.WriteLine("Numero al cuadrado: {0}", number_cuadrado);
                    Console.WriteLine("Numero al cubo: {0}", number_cubo);
                }
                else
                {
                    Console.WriteLine("Error. ¡Reingresar numero!");
                }
            }
            Console.ReadKey();
        }
    }
}
