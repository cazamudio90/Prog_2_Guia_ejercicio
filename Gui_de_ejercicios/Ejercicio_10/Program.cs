using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 10");
            string resp1;
            int aux_num;
            Console.WriteLine("Ingrese Cantidad de lineas para la base de la piramide");
            resp1 = Console.ReadLine();

            if (int.TryParse(resp1, out aux_num))
            {
                for (int i = 1; i < aux_num * 2; i += 2)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();

        }
    }
}
