using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 6");
            int aux_inicio;
            int aux_fin;
            string resp;
            string resp_2;

            Console.WriteLine("Ingrese un año de de inicio para calcular cuales son los años bisiestos");
            resp = Console.ReadLine();
            Console.WriteLine("Ingrese un año de de fin para calcular cuales son los años bisiestos");
            resp_2 = Console.ReadLine();

            if ( int.TryParse(resp, out aux_inicio) && int.TryParse(resp_2, out aux_fin) )
            {
                Console.WriteLine("Estos son los años bisiestos: ");
                for (int i = aux_inicio; i <= aux_fin; i++)
                {
                    if (i % 4 == 0)
                    {

                        if (i % 100 == 0 && i % 400 == 0)
                        {
                            Console.WriteLine(i);
                        }

                        if(i % 100 != 0)
                        {
                            Console.WriteLine(i);
                        }
                        
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
