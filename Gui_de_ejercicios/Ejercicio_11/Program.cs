using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            string resp;
            int aux_num;
            int v_acmululador = 0;
            int num_min = 0;
            int num_max = 0;
            int contador = 0;

            Console.WriteLine("Ingrse 10 numeros");

            for (int i = 0; i < numeros.Length; i++)
            {
                resp = Console.ReadLine();
                if (int.TryParse(resp, out aux_num))
                {
                    numeros[i] = aux_num;
                }
            }

            foreach (int item in numeros)
            {
                if(Validacion.Validar(item,-100, 100))
                {
                    
                    v_acmululador += item;
                    contador += 1;
                    Console.WriteLine(item);
                    if (contador == 1)
                    {
                        num_min = item;
                        num_max = item;
                    }
                    else
                    {
                        if (num_min >= item)
                        {
                            num_min = item;
                        }
                        if (num_max < item)
                        {
                            num_max = item;
                        }
                    }
                   
                }
            }

            Console.WriteLine("Contador {0}", contador);
            Console.WriteLine("Promedio: {0}", v_acmululador / contador);
            Console.WriteLine("Max: {0}", num_max);
            Console.WriteLine("Min: {0}", num_min);

            Console.ReadKey();
        }
    }
}
