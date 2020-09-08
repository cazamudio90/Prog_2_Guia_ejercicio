using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static int Calcular( int p_nun, int p_num_2, string p_operation)
        {
            int  v_total = 0;

            switch (p_operation)
            {
                case "+":
                    v_total = p_nun + p_num_2;
                    break;
                case "-":
                    v_total = p_nun - p_num_2;
                    break;
                case "*":
                    v_total = p_nun * p_num_2;
                    break;
                case "/":
                    if (Validar(p_num_2))
                    {
                        v_total = p_nun / p_num_2;
                    }
                    break;
            }

            return v_total;
        }

        private static bool Validar(int p_num)
        {
            if(p_num == 0)
            {
                return false;
            }else
            {
                return true;
            }
        }
    }
}
