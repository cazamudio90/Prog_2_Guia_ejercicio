using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux_num, aux_num_2;
            string resp;
            do
            {
                Console.WriteLine("Ingrese 2 numeros");
                if (int.TryParse(Console.ReadLine(), out aux_num) && int.TryParse(Console.ReadLine(), out aux_num_2))
                {
                    Console.WriteLine("Eliga la operacion que desea hacer (+, -, *, /)");
                    resp = Console.ReadLine();
                    Console.WriteLine("Total: {0}", Calculadora.Calcular(aux_num, aux_num_2, resp));
                }
                Console.WriteLine("Desea Continuar S/N");
                resp = Console.ReadLine();
            } while (resp == "S");
            Console.ReadKey();
        }
    }
}
