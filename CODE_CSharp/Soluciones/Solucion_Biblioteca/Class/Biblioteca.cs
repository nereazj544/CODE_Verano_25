using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Biblioteca.Class
{
    class Biblioteca
    {
        List<Libros> listBooks;

        public Biblioteca () { listBooks = new List<Libros>(); }

        public int GetContarLibros () { return listBooks.Count; }

        public void AddBook (Libros book) { listBooks.Add( book ); }

        public void RemoveBook (string titulo)
        {
            foreach ( Libros book in listBooks )
            {
                if ( book.GetTitulo() == titulo )
                {
                    listBooks.Remove( book );
                    break;
                }
            }
        }

        public void MostrarLibros ()
        {
            Console.WriteLine( $"\t====   LISTA DE LIBROS EN LA BIBLIOTECA  ====  " );
            foreach ( Libros book in listBooks )
            {
                int index = 0;

                Console.Write( $"{index++} - " );
                book.MostrarLibro();
                Console.WriteLine( "\n" );
            }
        }


    }
}
