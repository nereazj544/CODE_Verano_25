using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poli_1.Class
{
    class Negocio
    {
        //Atributos de la clase
        string propietario;
        string direccion;
        string telefono;

        //Metodo de la clase
        public Negocio ()
        {
            propietario =  "";
            direccion = "";
            telefono = "";
        }

        public void SetProp (string prop)
        { propietario = prop; }
        public void SetDir (string dir)
        { direccion = dir; }
        public void SetTlf (string tlf)
        { telefono = tlf; }

        public string GetProp ()
        { return propietario; }
        public string GetDir ()
        { return direccion; }
        public string GetTlf ()
        { return telefono; }

        //Se declara el metodo como virtual para que pueda ser sobreescrito en las clases que hereden de Negocio
        public virtual void Mostrar ()
        {
            Console.WriteLine( "-------------------------" );
            Console.WriteLine( $"Datos del Negocio" +
                $"\n\t- Propietario: {propietario}" +
                $"\n\t- Direccion: {direccion}" +
                $"\n\t- Telefono: {telefono}"
                );

            

        }

    }
}
