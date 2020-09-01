using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number to convert to binary: ");
            if (int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine(Conversor.decimalBinario(n));
            }
            Console.Write("Enter the number to convert to decimal: ");
           
            Console.WriteLine(Conversor.binarioDecimal(Console.ReadLine()));
           

            Console.ReadKey();
        }
    }
}
