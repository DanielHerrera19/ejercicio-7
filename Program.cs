using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota final del estudiante (0 a 100): ");
            int notafinal = int.Parse(Console.ReadLine());

            string calificacion;

            if (notafinal >= 90)
            {
                calificacion = "A";
            }
            else if (notafinal >= 80)
            {
                calificacion = "B";
            }
            else if (notafinal >= 70)
            {
                calificacion = "C";
            }
            else if (notafinal >= 60)
            {
                calificacion = "D";
            }
            else if (notafinal >= 0)
            {
                calificacion = "F";
            }
            else 
            {
                calificacion= "Ingrese una nota valida";
            }
           
            Console.WriteLine("Su calificación es: " + calificacion);
            Console.ReadKey();
        }
    }
}