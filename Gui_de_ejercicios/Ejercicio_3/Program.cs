using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 3");
            int aux_number;
            string resp;

            Console.WriteLine("Ingrese un numero");
            resp = Console.ReadLine();

            if ( int.TryParse(resp, out aux_number))
            {
                for (int i = 0; i <= aux_number; i++)
                {
                    if ( i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
