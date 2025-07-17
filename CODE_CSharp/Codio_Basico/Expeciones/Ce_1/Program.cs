

using System.Globalization;

class Program
{
    static void Main ()
    {
        Menu();
    }

    private static void Menu ()
    {
            bool cnt = false; ;
        try
        {
            while (!cnt)
            {

            int n1, n2;

            Console.WriteLine( "Numero 1:  " );
            Console.Write( "Respuesta :  " );
            n1 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine( "Numero 2:  " );
            Console.Write( "Respuesta :  " );
            n2 = Convert.ToInt32( Console.ReadLine() );

            if(n1 > 0 && n2 > 0)
                {
                    int s = n1 + n2;
                    int r = n1 - n2;
                    int m = n1 * n2;
                    int d = n1 / n2;
                    Console.WriteLine( "=================" );
                    Console.WriteLine( "RESULTADOS" );
                    Console.WriteLine( $"Suma: {s}, \n Resta{r} \n Multiplicacion{m} \n Division{d}" );
                    Console.WriteLine( "=================" );
                    Console.WriteLine("CONTINUAR ? (S/N)" );
                    string respuesta = Console.ReadLine().ToUpper();
                    if (respuesta.Equals("N"))
                    {
                        cnt = true;
                    }


                }
            }
        }
        catch ( Exception ex )
        {
            Console.WriteLine( "======== ERROR ========" );
            Console.WriteLine( "NUMERO INVALIDO" );
            Console.WriteLine( "=================" );
            /*
            Console.WriteLine("INFO DEL ERROR:");
            Console.WriteLine( $"Numero invalido: {ex}" );
            */
        }
        finally
        {
            Console.WriteLine( "=================" );
            Console.WriteLine( "FIN DEL PROGRAMA" );
            Console.WriteLine( "=================" );
            cnt = true;
           
        }
    }
}