using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1_proyecto_consola_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            //float c = a + b;
            //float


            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Programa de calculadora Basica \n\n";
            
            Console.WriteLine("semana 2 \n");

            Console.WriteLine("Escribe el primer numero");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el segundo numero");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Eliga una opcion de la sigiente lista:");
            Console.WriteLine("\ta - Sumar");
            Console.WriteLine("\ts - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("¿Tu opcion es ? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Tu resultado es: {a} + {b} = " + (a + b));
                    break;
                case "s":
                    Console.WriteLine($"Tu resultado es: {a} - {b} = " + (a- b));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado es: {a} * {b} = " + (a * b));
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so.
                    while (b == 0)
                    {
                        Console.WriteLine("Introduzca un divisor distinto de cero: ");
                        b = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Tu resultado es : {a} / {b} = " + (a / b));
                    break;
            }

            Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora...");
            Console.ReadKey();
        }
            // Wait for the user to respond before closing.

        }
    }

           //Console.Clear();
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Resultados: {0 }",c);

            //Console.ReadKey();
        