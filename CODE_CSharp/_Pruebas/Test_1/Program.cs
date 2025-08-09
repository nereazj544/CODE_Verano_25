//Idea: El usuario pone una palabra, si la pone bien se cierra el programa, si la pone mal, le da una pista y deja  probar otra vez.

using System;

class Program
{
    static void Main ()
    {
        Principal();
    }

    private static void Principal ()
    {

        #region BY NEO
        int numMax = 5;
        #endregion

        int intentos = 0;
        bool correcto = false;
        Console.WriteLine( "Adivina la palabra, tiene 4 letras" );

        do
        {
            string palabra = Console.ReadLine().ToUpper();
            Console.WriteLine( $"Intento numero {numMax}" );

            if ( palabra == "LAGO" )
            {
                Console.WriteLine( "\nMuy bien" );
                correcto = true;
            }

            else
            {
                Console.WriteLine( "\nNUH UH, inténtalo otra vez" );
                intentos++;
                numMax--;
               
            }

            if ( intentos >= 1 && !correcto )
            {
                Pista1();
            }

            if ( intentos >= 2 && !correcto )
            {
                Pista2();
            }


            #region BY NEO
            if ( numMax == 0 )
            {
                Console.WriteLine( $"\nNumero de intentos {numMax} agotados" );
                Console.WriteLine( "\nLa palabra era LAGO" );
                correcto = true;
            }

            #endregion





        } while ( !correcto );

    }

    private static void Pista1 ()
    {
        Console.WriteLine( "\nPista: La palabra empieza por L" );
    }

    private static void Pista2 ()
    {
        Console.WriteLine( "\nPista: La palabra acaba en O" );
    }


}


