using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aparatos.Clases
{
    // La herencia se coloca usando dos puntos (:) después del nombre de la clase
    class Lavadora : Electrodomestico
    {

        
        int RPM; // Revoluciones por minuto
        int kg; //Kilogramos de capacidad

        public Lavadora ()
        {
            RPM = 0; kg = 0;
        }

        public void SetRMP (int rev)
        {
            RPM = rev;
        }
        public int GetRPM ()
        {
            return RPM;
        }

        public void SetKg (int peso)
        {
            kg = peso;
        }
        public int GetKg ()
        {
            return kg;

        }


        public void Datos ()
        {
            
            Console.WriteLine( $" --- LAVADORA --- \n \t-RPM: {RPM} \n \t-KG: {kg}" );
            Console.WriteLine( $" \t-Encendido: {OnEncedido()} \n \t-Tension: {GetTension()}" );
            if(OnEncedido())
            {
                Console.WriteLine( "¡FUNCIONANDO!" );
            }
            else
            {

                Console.WriteLine( "¡APAGADA!" );
            }
        }



    }
}
