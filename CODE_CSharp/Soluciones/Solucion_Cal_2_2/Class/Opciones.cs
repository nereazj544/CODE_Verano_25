namespace Solucion_Cal_2_2.Class
{
    class Opciones
    {
        public void Matematicas (int text)
        {
            switch ( text )
            {
                case 1: Sumar(); break;
                case 2: Restar(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                case 5:
                    Console.WriteLine( ". . . SALIENDO DEL PROGRAMA . . ." );
                    break;
                default:
                    Console.WriteLine( "OPCION INVALIDA, POR FAVOR INGRESE UNA OPCION VALIDA (1-5)" );
                    break;
            }
        }

        private static void Sumar ()
        {
            try
            {
                Console.WriteLine( "OPCION - SUMAR" );
                int nm_1 = PedirNumero( "Primer número" );
                int nm_2 = PedirNumero( "Segundo número" );
                int r = nm_1 + nm_2;
                Console.WriteLine( $"Resultado de la SUMA: {nm_1} + {nm_2} = {r}" );
            }
            catch ( Exception ex )
            {
                MostrarError( ex );
            }
        }

        private static void Restar ()
        {
            try
            {
                Console.WriteLine( "OPCION - RESTA" );
                int nm_1 = PedirNumero( "Primer número" );
                int nm_2 = PedirNumero( "Segundo número" );
                int r = nm_1 - nm_2;
                Console.WriteLine( $"Resultado de la RESTA: {nm_1} - {nm_2} = {r}" );
            }
            catch ( Exception ex )
            {
                MostrarError( ex );
            }
        }

        private static void Multiplicar ()
        {
            try
            {
                Console.WriteLine( "OPCION - MULTIPLICACION" );
                int nm_1 = PedirNumero( "Primer número" );
                int nm_2 = PedirNumero( "Segundo número" );
                int r = nm_1 * nm_2;
                Console.WriteLine( $"Resultado de la MULTIPLICACION: {nm_1} * {nm_2} = {r}" );
            }
            catch ( Exception ex )
            {
                MostrarError( ex );
            }
        }

        private static void Dividir ()
        {
            try
            {
                Console.WriteLine( "OPCION - DIVIDIR" );
                int nm_1 = PedirNumero( "Primer número" );
                int nm_2 = PedirNumero( "Segundo número (≠0)" );
                if ( nm_2 == 0 )
                {
                    Console.WriteLine( "No se puede dividir por cero." );
                    return;
                }
                int r = nm_1 / nm_2;
                Console.WriteLine( $"Resultado de la DIVISION: {nm_1} / {nm_2} = {r}" );
            }
            catch ( Exception ex )
            {
                MostrarError( ex );
            }
        }

        private static int PedirNumero (string mensaje)
        {
            int n;
            Console.Write( $"{mensaje}. Respuesta: " );
            while ( !int.TryParse( Console.ReadLine(), out n ) )
            {
                Console.WriteLine( "Por favor, introduce un número válido." );
                Console.Write( $"{mensaje}. Respuesta: " );
            }
            return n;
        }

        private static void MostrarError (Exception ex)
        {
            Console.WriteLine( "== SE HA PRODUCIDO UN ERROR ==" );
            Console.WriteLine( "== INFORMACION ==" );
            Console.WriteLine( "Mensaje: " + ex.Message );
        }
    }
}
