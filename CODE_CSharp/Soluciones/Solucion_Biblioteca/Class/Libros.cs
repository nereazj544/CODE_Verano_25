using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Solucion_Biblioteca.Class
{
    class Libros
    {
        //Atributos de clase
        private string titulo;
        private string genero; //Add adicional
        private int ISBN;

        //Atributos de referencia a la clase: Autor
        private Autor autor;


        //Constructro
        public Libros (string title, string type, int isbn, Autor author)
        {
            titulo = title;
            genero = type;
            ISBN = isbn;
            autor = author; //Referencia a la clase Autor
        }

        //Metodos
        //! Mostrar titulo del libro
        public string GetTitulo ()
        {
            return titulo;
        }

        //Añadir Autor
        public void AddAuthor(Autor author)
        {
            autor = author;
        }


        public void MostrarLibro ()
        {
            Console.WriteLine( $"\t====   DATOS DEL LIBRO  ====  " );
            Console.WriteLine( $"1- Titulo del libro: {titulo}" );
            Console.WriteLine( $"2- Genero del libro: {genero}" );
            Console.WriteLine( $"3- ISBN del libro: {ISBN}" );
            Console.WriteLine($"4- Datos del autor: ");
            autor.MostrarAutor();
        }
    }
}
