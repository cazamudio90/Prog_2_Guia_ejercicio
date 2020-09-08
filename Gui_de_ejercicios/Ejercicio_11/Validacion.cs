using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int p_valor, int p_min, int p_max)
        {
            
            if (p_valor >= p_min && p_valor <= p_max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
