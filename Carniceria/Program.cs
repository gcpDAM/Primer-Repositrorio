using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Carpinteria:
            //*Solicitar el número de pies y pulgadas que vamos a convertir a cm(controlar que la parte decimal se pueda introducir con un "." o una ",").
            //*Operar con variables de tipo float.

            //* Mostrar la conversión a centímetros(1 pie = 12 pulgadas y 1 pulgada = 2,54 cm)
            //*Después, debe preguntar si hacer otra conversión(Si responde cualquier combinación de "si" o "s", debe limpiar la consola y volver a realizar otra conversión.
            //*Para asignar valor a una variable float se utiliza la letra f => pies = 2.5f;
            //*Para convertir un string en un float puedes usar Convert.ToSingle(valor); o float.Parse(valor);
            //*Ejemplo:
            //> Introduzca el número de pies: 27
            //> Introduzca el número de pulgadas: 8
            //> 27 pies y 8 pulgadas son 843,28 cm
            // >¿Desea realizar otra conversión(si/ no)?

            float pies, pulgada, cm;
            //bool si = true, no = false;
            string respuesta = "";

            //const float A = 2.54f;
            do
            {
                Console.Clear();
                Console.Write("Ingrese el número de pies que desea: ");
                pies = float.Parse(Console.ReadLine().Replace(".", ","));

                Console.Write("Ingrese el número de pugadas que desea: ");
                pulgada = float.Parse(Console.ReadLine().Replace(".", ","));

                cm = (pulgada * 2.54f) + (pies * 12 * 2.54f);

                Console.WriteLine(pies + " pies y " + pulgada + " pulgadas son: " + cm);

                Console.WriteLine("Desea realizar otra conversion (si/no)?");
                respuesta =(Console.ReadLine());
            } while (respuesta == "si" || respuesta=="s");






        }
    }
}
