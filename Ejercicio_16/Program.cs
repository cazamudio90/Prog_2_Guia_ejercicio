using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno_1 = new Alumno();
            Alumno alumno_2 = new Alumno();
            Alumno alumno_3 = new Alumno();

            alumno_1.apellido = "Perez";
            alumno_1.nombre = "Juan";
            alumno_1.legajo = 123;
            alumno_2.apellido = "Rodriguez";
            alumno_2.nombre = "Pedro";
            alumno_2.legajo = 456;
            alumno_3.apellido = "Morales";
            alumno_3.nombre = "Micaela";
            alumno_3.legajo = 789;

            Console.WriteLine("Ingrese Primera Nota y Segunda Nota del primer alumno");

            string nota1 = Console.ReadLine();
            string nota2 = Console.ReadLine();
            byte auxNota1;
            byte auxNota2;

            if (byte.TryParse(nota1, out auxNota1) && byte.TryParse(nota2, out auxNota2))
            {
                alumno_1.Estudiar((byte)auxNota1, (byte)auxNota2);
            }

            Console.WriteLine("Ingrese Primera Nota y Segunda Nota del segundo alumno");

            nota1 = Console.ReadLine();
            nota2 = Console.ReadLine();

            if (byte.TryParse(nota1, out auxNota1) && byte.TryParse(nota2, out auxNota2))
            {
                alumno_2.Estudiar((byte)auxNota1, (byte)auxNota2);
            }

            Console.WriteLine("Ingrese Primera Nota y Segunda Nota del tercer alumno");

            nota1 = Console.ReadLine();
            nota2 = Console.ReadLine();

            if (byte.TryParse(nota1, out auxNota1) && byte.TryParse(nota2, out auxNota2))
            {
                alumno_3.Estudiar((byte)auxNota1, (byte)auxNota2);
            }

            alumno_1.CalcularFinal();
            alumno_2.CalcularFinal();
            alumno_3.CalcularFinal();

            Console.WriteLine("Primer alumno primera nota, segunda nota, nota final");
            alumno_1.Mostrar();
            Console.WriteLine("Segundo alumno primera nota, segunda nota, nota final");
            alumno_2.Mostrar();
            Console.WriteLine("Tercer alumno primera nota, segunda nota, nota final");
            alumno_3.Mostrar();


            Console.ReadKey();
        }
    }
}
