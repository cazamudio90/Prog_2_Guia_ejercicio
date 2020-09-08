using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5");

            string resp;
            int aux_num;
            int v_primer_acumulador = 0;
            int v_segundo_acumulador = 0;

            Console.WriteLine("Ingrese un numero para calcular los centro numericos");
            resp = Console.ReadLine();

            if ( int.TryParse(resp,out aux_num))
            {
                for (int  i= 1;  i < aux_num; i++)
                {
                    v_primer_acumulador += i;

                    for (int j = i+2; j <= v_primer_acumulador; j++)
                    {
                        v_segundo_acumulador += j;
                        
                        if (v_primer_acumulador == v_segundo_acumulador)
                        {
                            Console.WriteLine("Centro numerico: {0}", i+1);
                        }
                    }
                    v_segundo_acumulador = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
