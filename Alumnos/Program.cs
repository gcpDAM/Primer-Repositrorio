using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {

            //        4.Alumnos:
            // *Solicitar el nombre de la asignatura.

            //* Solicitar la cantidad total de alumnos en la clase.
            // *Solicitar la calificación(puede llevar parte decimal) de cada uno de los alumnos.
            // *Mostrar la nota media(redondeada a dos valores decimales) de la clase para dicha asignatura.
            // *Ejemplo:
            //      >¿Cómo se llama la asignatura? Matemáticas
            //      >¿Cuántos alumnos son ? 7
            //      > Calificación del alumno 1: 3,5
            //       > Calificación del alumno 2: 8,25
            //        > Calificación del alumno 3: 7,75
            //         > Calificación del alumno 4: 10
            //          > Calificación del alumno 5: 9
            //           > Calificación del alumno 6: 4,5
            //            > Calificación del alumno 7: 1,25
            //             > La nota media de la clase para la asignatura Matemáticas es 6,32.
            string asignatura;
            int numAlumnos, contAlumnos = 1;
            decimal nota, notaClase= 0, media;

            Console.Write("¿Cómo se llama la asignatura? ");
            asignatura = Console.ReadLine();

            do
            {
                Console.Write("¿Cuántos alumnos son? ");
                int.TryParse(Console.ReadLine(), out numAlumnos);
            } while (numAlumnos < 1);

            do
            {
                do
                {
                    Console.Write("Calificación del alumno " + contAlumnos + ": ");
                    decimal.TryParse(Console.ReadLine().Replace(".", ","), out nota);
                    if(nota < 0 || nota > 10)
                    {
                        Console.Write("La nota debe estar entre 0 y 10\n");
                        //Console.Clear();
                    }
                } while (nota<0 || nota>10);

                notaClase = notaClase + nota;
                contAlumnos++;

            } while (contAlumnos <= numAlumnos);

            media = notaClase / numAlumnos;
            media = Math.Round(media, 2);

            Console.WriteLine("La nota media de la clase para la asignatura " + asignatura + " es " + media);

            
        }
    }
}
