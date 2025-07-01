//LIBRERIAS
using System;

// NOMBRE DEL ESPACIO 
namespace Basic3_Funciones
{
    class Program //Nombre de la clase
    {
        public static void Saludo() // Declaracion de una funcion (sin pasar parametros)
        {
            Console.WriteLine("=== METODO SIN PARAMETROS ===");
            Console.WriteLine("Hola usuario"); //Imprimir en la consola el saludo
            Console.WriteLine("\n=== === ===\n");

        }

        private static void Saludo_PR(string name) // Declaracion de una funcion (pasando parametros)
        {
            {
                Console.WriteLine("=== METODO CON PARAMETROS ===");
                Console.WriteLine($"Hola usuario: {name}"); //Imprimir en la consola el saludo
                Console.WriteLine("\n=== === ===\n");
            }

        }

        static void Main() //Funcion principal donde se ejecuta todo el programa
        {
            //TODO: FUNCION SIN PARAMETROS
            //Llamar a la funcion Saludo
            Saludo(); //No se le pasan parametros


            //TODO: FUNCION CON PARAMETROS

            Console.Write("Tu nombre: ");
            string name = Console.ReadLine();

            //Llamar a la funcion Saludo_PR
            Saludo_PR(name); //A esta funcion se le pasa un parametro de tipo STRING (se pueden pasar otros tipos de datos)

        }


    }
}