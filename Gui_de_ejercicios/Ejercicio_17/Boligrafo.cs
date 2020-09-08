using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_bol
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(ConsoleColor p_color, short p_tinta)
        {
            this.color = p_color;
            setTinta(p_tinta);
        }
        
        public short getTinta()
        {
            return this.tinta;
        }

        public ConsoleColor getColor()
        {
            return this.color;
        }

        private void setTinta(short p_tinta)
        {
            if (p_tinta >= 0 && p_tinta <= cantidadTintaMaxima)
            {
                this.tinta = p_tinta;
            }
        }

        public void recargarTinta()
        {
            setTinta(cantidadTintaMaxima);
        }

        public bool pintar(short p_gasto, out string p_dibujo)
        {
            bool v_return = false;
            p_dibujo = null;
            int v_gasto;
            var out_return = new System.Text.StringBuilder();
            v_gasto = Convert.ToInt32(this.getTinta()) - Convert.ToInt32(p_gasto);

            setTinta(Convert.ToInt16(v_gasto));

            if (this.getTinta() >= p_gasto )
            {
                for (int i = 0; i < Convert.ToInt32(p_gasto); i++)
                {
                    out_return.Append("*");
                    v_return = true;
                }
                p_dibujo = out_return.ToString();
            }

            return v_return;
        }

    }
}
