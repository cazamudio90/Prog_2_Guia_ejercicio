using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4");
            int contador = 0;
            int i = 1;
            int j = 1;
            int acumulador = 0;

            for (i = 1; contador < 4; i++)
            {
                acumulador = 0;

                for (j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;
                    }
                }

                if (acumulador == i)
                {
                    contador += 1;
                    Console.WriteLine("El numero " + i + " es perfecto");
                }
            }
            Console.ReadKey();
        }
    }
}
