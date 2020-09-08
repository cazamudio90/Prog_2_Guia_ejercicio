using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_17_bol;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 17");
            string v_diujo_1;
            string v_diujo_2;

            Boligrafo bic_1 = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo bic_2 = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine("boligrafo 1 tinta: {0}, color: {1}", bic_1.getTinta(), bic_1.getColor());
            Console.WriteLine("boligrafo 2 tinta: {0}, color: {1}", bic_2.getTinta(), bic_2.getColor());

            if (bic_1.pintar(30, out v_diujo_1))
            {
                Console.WriteLine("Boligrafo 1 puede gastar: {0}", v_diujo_1);
            }

            if (bic_2.pintar(6, out v_diujo_2))
            {
                Console.WriteLine("Boligrafo 2 puede gastar: {0}", v_diujo_2);
            }

            Console.ReadKey();
        }
    }
}
