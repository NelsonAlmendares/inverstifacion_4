using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investigacion_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos las caracticas de la consola
            Console.WindowHeight = 25;
            Console.WindowWidth = 110;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            // Titulo de la consola:
            Console.Title = "Ejercicio de Triangulos";
            Console.Write("\n\t\t\t\t Ejercicio 1 Guía #4 Investigación Complementaria");

            // Definimos las variables con las que vamos a trabajar
            double lado1, base_triangulo, lado2, lado3, resultado;
            string opcion, accion;

            try
            {
                do
                {
                    Console.Clear();
                    // Solicitamos los datos al usuario
                    Console.Write("\n");
                    Console.Write("\n\t\t Qué tipo de triangulo desea realizar");
                    Console.Write("\n");
                    // Solicitamos los datos al usuario
                    Console.Write("\n\t\t A) Equilátero ");
                    Console.Write("\n\t\t B) Isóceles ");
                    Console.Write("\n\t\t C) Rectángulo ");
                    Console.Write("\n");
                    Console.Write("\n\t\t Opcción : ");
                    opcion = Console.ReadLine();

                    // Trabajamos con los datos ingresados 
                    switch (opcion)
                    {
                        case "A":
                            Console.Clear();
                            // Titulo de la opcción 1 de la consola:
                            Console.Title = "Ejercicio de Triangulos";
                            Console.Write("\n");
                            Console.Write("\n\t\t\t\t Ejercicio 1 Guía #4 Investigación Complementaria");
                            Console.Write("\n");
                            Console.Write("\n\t\t\t\t     Ingrese el primer lado del triangulo : ");
                            lado1 = double.Parse(Console.ReadLine());
                            // Trabajamos con los datos:
                            resultado = lado1 * 3;
                            Console.Write("\n");
                            Console.Write("\n\t\t\t\t El perímetro del triángulo es : " + resultado);
                            break;
                        case "B":
                            Console.Clear();
                            // Titulo de la opcción 1 de la consola:
                            Console.Title = "Ejercicio de Triangulos";
                            Console.Write("\n");
                            Console.Write("\n\t\t\t\t Ejercicio 1 Guía #4 Investigación Complementaria");
                            Console.Write("\n");
                            // Solicitamos los datos al usuario
                            Console.Write("\n\t\t\t\t     Ingrese la base del triangulo : ");
                            base_triangulo = double.Parse(Console.ReadLine());
                            Console.Write("\n\t\t\t\t Ingrese uno de los lados del triangulo : ");
                            lado1 = double.Parse(Console.ReadLine());
                            // Manejamos los datos ingresados
                            resultado = lado1 * 2 + base_triangulo;
                            Console.Write("\n");
                            Console.Write("\n\t\t\t\t El perímetro del tríangulo es : " + resultado);

                            break;
                        case "C":
                            Console.Clear();
                            // Titulo de la opcción 1 de la consola:
                            Console.Title = "Ejercicio de Triangulos";
                            Console.Write("\n");
                            Console.Write("\n\t\t\t\t Ejercicio 1 Guía #4 Investigación Complementaria");
                            Console.Write("\n");
                            // Solicitamos los datos al usuario
                            Console.Write("\n\t\t\t\t     Ingrese el primer lado del triangulo  : ");
                            lado1 = double.Parse(Console.ReadLine());
                            Console.Write("\n\t\t\t\t     Ingrese el segundo lado del triangulo : ");
                            lado2 = double.Parse(Console.ReadLine());
                            // Trabajamos con los datos

                            double potencia1 = Math.Pow(lado1, 2);
                            double potencia2 = Math.Pow(lado2, 2);
                            double suma = potencia1 + potencia2;
                            lado3 = Math.Sqrt(suma);
                            resultado = lado1 + lado2 + lado3;
                            //Mostramos los datos
                            Console.Write("\n\t\t\t\t El perímetro del tríangulo es : " + Math.Round(resultado, 3));
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n\t\t La opcción ingresada no coincide con las operaciones registradas");
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                    }

                    Console.Write("\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n\t\t\t\t      Desea volver a realizar un cálculo : ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    accion = Console.ReadLine();

                } while (accion == "YES" || accion == "Yes" || accion == "yes");

                Console.Write("\n\n");
                Console.Write("\t\t");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(" ***************************************************************************** ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\t * ***************************************** *");
                Console.WriteLine("\t\t\t\t\t * Este programa fue diseñado por: *");
                Console.WriteLine("\t\t\t\t * ***************************************** *");
                Console.WriteLine("\t\t\t\t\t * Nelson Almendares *");
                Console.WriteLine("\t\t\t\t * ***************************************** *");
                Console.Write("\t\t");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(" ***************************************************************************** ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("\t");

                Console.Write("\n");
                Console.Write("\n\t\t --> Fin de la ejecución del programa");
                Console.Write("\n\t\t --> Pulse cualquier tecla");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\t\t\t\t" + ex.Message);
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}
