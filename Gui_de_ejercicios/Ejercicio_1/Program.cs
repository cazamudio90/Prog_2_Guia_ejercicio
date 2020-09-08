using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_dce_Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");

            string Numeros;
            int aux_number;
            int v_menor = 0;
            int v_Mayor = 0;
            int v_acumulador = 0;

            Console.WriteLine("Ingrese 5 numeros");

            for (int i = 0; i < 5; i++)
            {
                Numeros = Console.ReadLine();
              if ( int.TryParse(Numeros, out aux_number))
                {
                    if (i == 0)
                    {
                        v_menor = aux_number;
                        v_Mayor = aux_number;
                    }
                    else
                    {
                        if (aux_number > v_Mayor)
                        {
                            v_Mayor = aux_number;
                        }else if (aux_number < v_menor)
                        {
                            v_menor = aux_number;
                        }
                    }
                    v_acumulador = v_acumulador + aux_number;
                }
            }

            Console.WriteLine("Valor Minimo: {0}",v_menor);
            Console.WriteLine("Valor Maximo: {0}", v_Mayor);
            Console.WriteLine("Promedio: {0}", (v_acumulador/ 5));

            Console.ReadKey();
        }

        
    }
}
