using System;
using System.Globalization;

namespace LAB_SEMANA_12_EJEMPLO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            string[] Nombre;
            int[] Nacimiento;
            string[] Puesto;
            int[] Salario;
            int Edad;
            

            Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
            Console.WriteLine("Presione 1: ------>  Registro de nombres y edades ");
            Console.WriteLine("Presione 2: ------>  REgistro de puestos y salarios");
            Console.WriteLine("Presione 3: ------>  Salir");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                
                    Nombre = new string[5];
                    Nacimiento = new int[5];
                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine("Ingrese su nombre: ");
                        Nombre[f] = Console.ReadLine();

                        Console.WriteLine("Ingrese el año de su nacimiento: ");
                        Nacimiento[f] = int.Parse(Console.ReadLine());
                    }

                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("El nombre y edad de la persona es: ");
                        Edad = 2022 - Nacimiento[f];
                        Console.WriteLine("Se llama " + Nombre[f] + " y tiene " + Edad + " años.");
                    }

                    break;

                case "2":
                   
                    Puesto = new string[5];
                    Salario = new int[5];
                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine("Ingrese el puesto de trabajo: ");
                        Puesto[f] = Console.ReadLine();

                        Console.WriteLine("Ingrese el salario a pagar en el puesto: ");
                        Salario[f] = int.Parse(Console.ReadLine());
                    }

                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("El puesto con su respectivo salario es: ");
                        Console.WriteLine("El puesto de " + Puesto[f] + " recibira un slario de Q" + Salario[f]);
                    }


                    break;



                case "3":
                    Console.WriteLine("Usted salio del programa");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese una opción del 1 al 3");
                    break;

            }

        }
    }
} 
