using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Ejercicio 8");
            string resp1;
            string resp2;
            string resp3;
            string resp4;
            int aux_hora;
            int aux_antiguedad;
            int aux_hr_mes;
            int cant_anos_val = 150;
            float total;

            Console.WriteLine("Ingrese Valor de la hora");
            resp1 = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre");
            resp2 = Console.ReadLine();
            Console.WriteLine("Ingrese antiguedad");
            resp3 = Console.ReadLine();
            Console.WriteLine("Ingrese De Horas Trabajadas al Mes");
            resp4 = Console.ReadLine();

            if (int.TryParse(resp1, out aux_hora) && int.TryParse(resp3, out aux_antiguedad) && int.TryParse(resp4, out aux_hr_mes) )
            {

                total = (aux_hr_mes * aux_hora) + (aux_antiguedad * cant_anos_val);


                Console.WriteLine("{0} :", resp2);
                Console.WriteLine("Antiguedad: {0}", aux_antiguedad);
                Console.WriteLine("Valor de la hora: {0}", aux_hora);
                Console.WriteLine("Porcentaje de Descuento: {0}", (total * 0.13));
                Console.WriteLine("Sueldo Bruto: {0} :", total);
                Console.WriteLine("Sueldo Neto: {0} :", total - (total * 0.13) );

            }
            Console.ReadKey();
        }
    }
}
