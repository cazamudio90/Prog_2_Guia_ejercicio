using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {

        public static string decimalBinario(int p_num)
        {
            int[] a = new int[10];
            int i;
            string v_return = "";

            for (i = 0; p_num > 0; i++)
            {
                a[i] = p_num % 2;
                p_num = p_num / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                v_return = v_return + a[i] ;
            }
            return v_return;
        }

        public static int binarioDecimal(string p_binary)
        {
            int num, binVal, decVal = 0, baseVal = 1, rem;
            num = int.Parse(p_binary);
            binVal = num;
            while (num > 0)
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }

            return decVal;
        }
    }
}
