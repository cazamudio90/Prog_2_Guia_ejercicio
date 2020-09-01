using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public string apellido;
        public string nombre;
        public int legajo;

        public void Estudiar(byte p_nota_1, byte p_nota_2)
        {
            nota1 = p_nota_1;
            nota2 = p_nota_2;
        }

        public void CalcularFinal()
        {
            Random numeroRamdon;

            if (nota1 >= 4 && nota2 >= 4)
            {
                numeroRamdon = new Random();

                notaFinal = numeroRamdon.Next(0,10);

               // notaFinal = ((nota1 + nota2) / 2);
            }
            else
            {
                notaFinal = -1;
                /*numeroRamdon = new Random();

                notaFinal = numeroRamdon.Next(0,10);*/
            }
        }
        public void Mostrar()
        {
            Console.WriteLine("Primera Nota {0}", nota1);
            Console.WriteLine("Segunda Nota {0}", nota2);
            Console.WriteLine("Nota Final {0}", notaFinal);
        }

            

    }
}
