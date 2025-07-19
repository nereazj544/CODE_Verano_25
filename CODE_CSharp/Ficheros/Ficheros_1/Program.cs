
using System.IO;

class Program
{
    static void Main ()
    {
        Ej1_Fichero(); //Leer contenido del fichero
        Console.WriteLine("");
        Ej2_Fichero(); //Escribir contenido en el fichero
    }



    private static void Ej1_Fichero ()
    {
        string path = "C:\\Users\\nzjha\\Desktop\\CODE\\CODE_Verano_25\\" +
            "CODE_CSharp\\Ficheros\\Ficheros_1\\RES\\File_1.txt"; // Ruta del fichero a leer

        try
        {

            using ( StreamReader rd = new StreamReader( path ) )
            {
                Console.WriteLine( "CONTENIDO DEL FICHERO: " );
                Console.WriteLine( "" );
                while ( !rd.EndOfStream )
                {
                    Console.WriteLine( rd.ReadLine() );
                }
            }

        }
        //CAPTURA DE EXCEPCIONES
        catch ( Exception ex )
        {
            switch ( ex )
            {
                //EXCEPCIONES ESPECIFICAS:
                case FileNotFoundException:
                    Console.WriteLine( $"Fichero no encontrado: \n \t{ex.Message}" );
                    break;
                case DirectoryNotFoundException:
                    Console.WriteLine( $"Directorio no encontrado: \n \t{ex.Message}" );
                    break;
                case UnauthorizedAccessException:
                    Console.WriteLine( $"Sin permisos de acceso: \n \t{ex.Message}" );
                    break;
                case IOException:
                    Console.WriteLine( $"Error de entrada/salida: \n \t{ex.Message}" );
                    break;

                //ERROR GENERAL:
                default:
                    Console.WriteLine( $"Error inesperado: \n \t{ex.Message}" );
                    break;
            }
        }
    }




    private static void Ej2_Fichero ()
    {
        string path = "C:\\Users\\nzjha\\Desktop\\CODE\\CODE_Verano_25\\" +
             "CODE_CSharp\\Ficheros\\Ficheros_1\\RES\\File_2.txt"; // Ruta del fichero a CREAR
        try
        {

            // Verificar si el fichero existe
            if ( !File.Exists( path ) )
            {
                File.Create( path ).Close(); // Crear el fichero si no existe
                Console.WriteLine( $"Fichero creado: {path}" );
            }

            bool isEnd = false;
            //Escribirmos en el fichero creado
            using ( StreamWriter wr = new StreamWriter( path, false ) )
            {
                Console.WriteLine( "Escribe: ('fin' para finalizar)" );

                while ( !isEnd )
                {
                    string line = Console.ReadLine();
                    Console.Write("Escribe ('fin' para acabar): ");

                    if ( line.ToLower() == "fin" )
                    {
                        isEnd = true; // Finalizar la escritura si se ingresa 'fin'
                    }

                        wr.WriteLine( line ); // Escribir la línea en el fichero

                }
            }
        }
        //CAPTURA DE EXCEPCIONES
        catch ( Exception ex )
        {
            switch ( ex )
            {
                //EXCEPCIONES ESPECIFICAS:
                case FileNotFoundException:
                    Console.WriteLine( $"Fichero no encontrado: \n \t{ex.Message}" );
                    break;
                case DirectoryNotFoundException:
                    Console.WriteLine( $"Directorio no encontrado: \n \t{ex.Message}" );
                    break;
                case UnauthorizedAccessException:
                    Console.WriteLine( $"Sin permisos de acceso: \n \t{ex.Message}" );
                    break;
                case IOException:
                    Console.WriteLine( $"Error de entrada/salida: \n \t{ex.Message}" );
                    break;

                //ERROR GENERAL:
                default:
                    Console.WriteLine( $"Error inesperado: \n \t{ex.Message}" );
                    break;
            }
        }
    }
}