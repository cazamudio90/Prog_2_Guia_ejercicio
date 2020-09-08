using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de Cuadrado {0}",CalculoDeArea.CalcularCuadrado(20));
            Console.WriteLine("Area de triangulo {0}",CalculoDeArea.CalcularTriangulo(20, 10));
            Console.WriteLine("Area de Ciruclo {0}",CalculoDeArea.CalcularCircuylo(10));

            Console.ReadKey();
            
        }
    }
}
