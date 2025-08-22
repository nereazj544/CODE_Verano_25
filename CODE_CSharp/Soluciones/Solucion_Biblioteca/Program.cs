using Solucion_Biblioteca.Class;

class Program
{

    private Biblioteca b = new Biblioteca();

    static void Main ()
    {
        
            MostarBienvenida();
      
    }

    private static void MostarBienvenida ()
    {
        Console.WriteLine( "========================================" );
        Console.WriteLine( " " );
        Console.WriteLine( "===  BIENVENIDO A LA BIBLIOTECA  ===" );
        Console.WriteLine( "\t 1 -  Añadir libro a la biblioteca" );
        Console.WriteLine( "\t 2 -  Mostrar biblioteca" );
        Console.WriteLine( "\t 3 -  Borrar libro" );
        Console.WriteLine( "\t 4 -  Total de libros" );
        Console.WriteLine( "\t 5 -  Salir  " );
        Console.WriteLine( " " );
        Console.WriteLine( "========================================" );

        Console.Write( "Opcion (1 al 5):  " );
        int num = Convert.ToInt32( Console.ReadLine() );
        //  num = int.Parse( Console.ReadLine() );
        GestionRespuesta( num );

    }

    private static void GestionRespuesta (int num)
    {
        bool exit = false;
        Biblioteca b = new Biblioteca();

        while ( !exit )
        {

        switch ( num )
        {
            case 1:
                Console.WriteLine( "Has elegido la opcion 1: Añadir libro a la biblioteca" );
                addBooktoLibery( b );
                break;
            case 2:
                Console.WriteLine( "Has elegido la opcion 2: Mostrar biblioteca" );
                b.MostrarLibros();
                break;
            case 3:
                Console.WriteLine( "Has elegido la opcion 3: Borrar libro" );
                break;
            case 4:
                Console.WriteLine( "Has elegido la opcion 4" );
                b.GetContarLibros();
                break;
            case 5:
                Console.WriteLine( "Saliendo del programa..." );
                    exit = true;
                    return;
            default:
                Console.WriteLine( "Opcion no valida, elige una opcion entre el 1 y el 5" );
                break;
        }
        }

    }

    static Biblioteca addBooktoLibery (Biblioteca b)
    {


        string nombre, apellido, nacionalidad; //Autor
        string titulo, genero; //Libro I
        long isbn; //Libro II

        Console.WriteLine( "Nombre del autor" );
        nombre = Console.ReadLine();
        Console.WriteLine( "Apellido del autor" );
        apellido = Console.ReadLine();
        Console.WriteLine( "Nacionalidad del autor" );
        nacionalidad = Console.ReadLine();

        Console.WriteLine( "Nombre del libro" );
        titulo = Console.ReadLine();
        Console.WriteLine( "Genoro  del libro" );
        genero = Console.ReadLine();
        Console.WriteLine( "ISBN del libro (13 caracteres)" );
        isbn = (long) Convert.ToDouble( Console.ReadLine() );


        Autor a = new Autor( nombre, apellido, nacionalidad );
        Libros l = new Libros( titulo, genero, isbn, a );
        b.AddBook( l );
        l.AddAuthor( a );

        Console.WriteLine( "Libro añadido correctamente, desea añadir otro (s/n)" );
        string r = Console.ReadLine().ToLower();
        if ( r == "s" )
        {
            addBooktoLibery( b );
        }
        else
        {
            Main();
        }
        return b;
    }



} //END CLASS


