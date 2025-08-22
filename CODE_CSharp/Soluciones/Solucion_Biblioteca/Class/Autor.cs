using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Biblioteca.Class
{
    class Autor
    {
        private string nombre;
        private string apellido;
        private string nacionalidad; // Añadido adicional


        //Constructor
        public Autor (string name, string lastName, string nationality)
        {
            //! NOTE: Los nombres del parametro son "diferentes" para evitar confusiones y no usar el 'this'

            nombre = name;
            apellido = lastName;
            nacionalidad = nationality;
        }


        // Metodo
        public void MostrarAutor ()
        {
            Console.WriteLine($"\t====   DATOS DEL AUTOR  ====  " );
            Console.WriteLine($"1- Nombre del autor: {nombre}");
            Console.WriteLine($"2- Apellido del autor: {nombre}");
            Console.WriteLine($"3- Nacionalidad del autor: {nombre}");
        }

    }
}
