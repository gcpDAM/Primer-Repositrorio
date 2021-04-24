using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //        3.Factorial:
            // *Calcular el factorial de un número menor de 20.

            //* El resultado debe mostrar dos líneas: una con el resultado y otra con toda la operación y el resultado.

            //* Ejemplo:
            //      > Introduzca un número menor de 20: 6
            //       > El factorial de 6 es 720.

            //        > 6! = 6 x 5 x 4 x 3 x 2 x 1 = 720.

            int num,cont,fact=1;
            string mensaje;
            do
            {
                Console.Write("Ingrese un número menor de 20: ");
                int.TryParse(Console.ReadLine(), out num);
            } while (num < 1 || num > 19);

            cont = num;
            do
            {
                fact = fact * cont;
                cont--;

            } while (cont >= 1);

            Console.WriteLine("El factorial de "+num+" es "+fact+".");

            mensaje = num + "! = "+num;
            int i = num - 1;

            do
            {
                mensaje = mensaje+" x "+ i;
                i--;
            } while (i >= 1);

            Console.WriteLine(mensaje+" = "+fact+".");
        }
    }
}
