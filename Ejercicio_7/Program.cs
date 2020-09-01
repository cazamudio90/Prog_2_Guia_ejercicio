using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 7");
            string resp_1;
            DateTime aux_date = new DateTime();
            int v_cant_day = 09;



            Console.WriteLine("Ingrese fecha de nacimiento DD/MM/YYYY");
            resp_1 = Console.ReadLine();
            if(DateTime.TryParse(resp_1, out aux_date))
            {
                while (aux_date < DateTime.Now)
                {
                    //Console.WriteLine(aux_date);
                    
                    aux_date = aux_date.AddDays(1);
                    v_cant_day += 1;
                }
                Console.WriteLine("vivio {0} dias", v_cant_day);
            }

            Console.ReadKey();
        }
    }
}
