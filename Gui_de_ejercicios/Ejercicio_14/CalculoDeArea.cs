using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double p_lado)
        {
            return p_lado * p_lado;
        }
        public static double CalcularTriangulo(double p_base, double p_altura)
        {
            return p_base * p_altura;
        } 
        public static double CalcularCircuylo(double p_lado)
        {
            return 3.14 * (p_lado * p_lado);
        } 
    }
}
