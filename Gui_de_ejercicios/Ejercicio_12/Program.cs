using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            int aux_num;
            int v_acuulador = 0;
            char resp_2;

            
            do
            {
                Console.WriteLine("Ingrse Numero Entrero");
                resp = Console.ReadLine();
                if (int.TryParse(resp, out aux_num))
                {
                    v_acuulador += aux_num;
                }

                Console.WriteLine("Desea Continuar (S/N)");
                if (char.TryParse(Console.ReadLine(), out resp_2))
                {

                }

            } while (ValidarRespuesta.ValidaS_N(resp_2));

            Console.WriteLine("Total {0}",v_acuulador);

            Console.ReadKey();
        }
    }
}
