using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            //        2.DiaSemana:
            // *Solicitar un número del 1 al 7.

            //* Mostrar por consola un mensaje cualquiera con el nombre del día al que corresponde.

            //* Si introdujo un número distinto debe mostrar "La opción no es válida".

            //* Ejemplos:
            //      > Introduzca un número del 1 al 7: 5
            //       > Ojalá fuera VIERNES

            //      > Introduzca un número del 1 al 7: 1
            //       > Me encanta empezar la semana con un gran LUNES

            //      > Introduzca un número del 1 al 7: 8
            //       > La opción no es válida

            int dia,cont = 0;
            do
            {
                

                do
                {
                    
                    Console.Write("introduzca un numero del 1 al 7: ");
                    int.TryParse(Console.ReadLine(), out dia);
                    if (dia < 1 || dia > 7)
                    {
                        Console.WriteLine("la opcion no es válida");
                    }
                } while (dia < 1 || dia > 7);

                //Console.WriteLine();

                switch (dia)
                {
                    case 1:
                        Console.WriteLine("\nNada como un buen LUNES para comenzar la semana");
                        break;
                    case 2:
                        Console.WriteLine("\nLos MARTES siempre suelen sorprender");
                        break;
                    case 3:
                        Console.WriteLine("\nMIERCOLES de cervezas con amigos");
                        break;
                    case 4:
                        Console.WriteLine("\nQue olor a fin de semana tiene este JUEVES");
                        break;
                    case 5:
                        Console.WriteLine("\nAl fin VIERNES!!!");
                        break;
                    case 6:
                        Console.WriteLine("\nEs SABADO y tu cuerpo lo sabe!");
                        break;
                    case 7:
                        Console.WriteLine("\nDomingo de descanso");
                        break;

                  
                        
                }


                Console.WriteLine("\n");
                cont++;
            } while (cont <= 3);
        }
    }
}
