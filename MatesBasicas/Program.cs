using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //        5.MatesBasicas:
            // *Mostrar un menú como el siguiente:
            //      > 1 - Suma
            //      > 2 - Resta
            //      > 3 - Multiplicación
            //      > 4 - División
            //      > 5 - SALIR
            // * Si selecciona la opción 5 debe terminar el programa.
            // *Si selecciona una opción del 1 al 4 debe solicitar dos números y realizar la operación matemática y mostrar el resultado.

            //* No es posible la división por cero.
            // *El resultado si tiene parte decimal debe estar redondeado a 3 decimales.

            //* Ejemplo:
            //      > MENU del programa MATESBÁSICAS:
            //      > 1 - Suma
            //      > 2 - Resta
            //      > 3 - Multiplicación
            //      > 4 - División
            //      > 5 - SALIR
            //      > Seleccione una opción: 2
            //       > Ha seleccionado la opción RESTA.
            //      > Introduzca el primer número: 6
            //       > Introduzca el segundo número: 5
            //        > El resultado de la resta 6 - 5 = 1.

            //         > Pulse una tecla para continuar...
            //      (Después de pulsar cualquier tecla debe limpiar la pantalla y volver a mostrar el menú)
            int opc;
            decimal num1, num2;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("    Menu de MatesBasicas    ");
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Multiplicación");
                Console.WriteLine("4 - División");
                Console.WriteLine("5 - SALIR");
                Console.WriteLine();


                bool ok;

                do
                {
                    //Console.Write(temp);
                    ok = int.TryParse(Console.ReadLine(), out opc);
                    if (ok==false || opc < 1 || opc > 5)
                    {
                        Console.Write("Opción incorrecta, introduzca un valor entre 1 y 5: "); 
                    }
                    
                } while (opc < 1 || opc > 5);

                
                
                    Console.Clear();
                   
                    
                switch(opc)
                {
                    
                    case 1:
                        Console.WriteLine("Ha seleccionado la opcion suma");
                        Console.Write("Ingrese el primer número: "); 
                        decimal.TryParse(Console.ReadLine().Replace(".", ","), out num1);
                        Console.Write("Ingrese el segundo número: ");
                        decimal.TryParse(Console.ReadLine().Replace(".", ","), out num2);
                        num1 = Math.Round(num1, 3);
                        num2 = Math.Round(num2, 3);                        
                        Console.WriteLine("La resultado de "+num1+" + "+num2+" es: "+(num1+num2));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado la opcion resta");
                        Console.Write("Ingrese el primer número: ");
                        decimal.TryParse(Console.ReadLine().Replace(".", ","), out num1);
                        Console.Write("Ingrese el segundo número: ");
                        decimal.TryParse(Console.ReadLine().Replace(".", ","), out num2);
                        num1 = Math.Round(num1, 3);
                        num2 = Math.Round(num2, 3);
                        Console.WriteLine("La resultado de " + num1 + " - " + num2 + " es: " + (num1 - num2));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ha seleccionado la opcion multiplicación");
                        Console.Write("Ingrese el primer número: ");
                        decimal.TryParse(Console.ReadLine().Replace(".", ","), out num1);
                        Console.Write("Ingrese el segundo número: ");
                        decimal.TryParse(Console.ReadLine().Replace(".", ","), out num2);
                        num1 = Math.Round(num1, 3);
                        num2 = Math.Round(num2, 3);
                        Console.WriteLine("La resultado de " + num1 + " x " + num2 + " es: " + (num1 * num2));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Ha seleccionado la opcion división");
                        Console.Write("Ingrese el primer número: ");
                        decimal.TryParse(Console.ReadLine().Replace(".", ","), out num1);
                        Console.Write("Ingrese el segundo número: ");
                        decimal.TryParse(Console.ReadLine().Replace(".", ","), out num2);
                        num1 = Math.Round(num1, 3);
                        num2 = Math.Round(num2, 3);                       
                        if (num2 != 0)
                        {
                            Console.WriteLine("El resultado de " + num1 + " / " + num2 + " es: " + (num1 / num2));
                            Console.ReadKey();
                        }
                        
                        break;
                }
                

            } while (opc != 5);
           
        }

        //static void sumaNumeros(decimal num1, decimal num2)
        //{
        //    Console.Clear();

        //    decimal resultado = num1 + num2;
        //    resultado = Math.Round(resultado, 3);
        //    Console.Write(resultado);
            

        //}
    }
}
