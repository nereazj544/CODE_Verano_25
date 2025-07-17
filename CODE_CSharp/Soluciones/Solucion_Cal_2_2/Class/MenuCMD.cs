using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Cal_2_2.Class
{
    class MenuCMD
    {
        public MenuCMD ()
        { }

        public void ShowMenu ()
        {
            Console.WriteLine( "\n== CALCULADORA _ SOLCUION ==\n" );
            Console.WriteLine( "1. Sumar" );
            Console.WriteLine( "2. Restar" );
            Console.WriteLine( "3. Multiplicar" );
            Console.WriteLine( "4. Dividir" );
            Console.WriteLine( "5. Salir" );
        }
        public void MenuRespuesta (string texto)
        {
            bool _v = false;

            //Convertir el texto a un numero
            try
            {
                while ( !_v )
                {

                    int _numconver = int.Parse( texto );
                    _v = true;

                    Opciones op = new Opciones();
                    op.Matematicas( _numconver );
                }

            }
            catch ( Exception ex )
            {
                Console.WriteLine( "== SE HA PRODUCIDO UN ERROR == " );
                Console.WriteLine( " " );
                Console.WriteLine( "== INFORMACION == " );
                Console.WriteLine( "Mensaje: " + ex.Message );
            }



        }

    }
}
