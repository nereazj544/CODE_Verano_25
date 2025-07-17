using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Poli_1.Class
{
    // Clase Hotel que hereda de Negocio
    class Hotel : Negocio
    {
        int numHab;
        int numEstre;

        public Hotel ()
        { numEstre = 0; numHab = 0; }


        public void SetNumHab (int hab)
        { numHab = hab; }
        public void SetNumEstrellas (int estre)
        { numHab = estre; }

        //Se declaran los metodos Get para obtener los valores de los atributos, como overrride
        public override void  Mostrar ()
        {
            Console.WriteLine( "-------------------------" );
            Console.WriteLine($"Datos del Hotel" +
                $"\n\t- Propietario: {GetProp()}" +
                $"\n\t- Direccion: {GetDir()}" +
                $"\n\t- Telefono: {GetTlf()}" +
                $"\n\t- Numero de habitaciones: {numHab}" +
                $"\n\t- Numero de estrellas: {numEstre}"
                );

        }


    }
}
