using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basci4_Class.Class
{

    class Person
    {
        //TODO: ATRIBUTOS (variables) DE LA CLASE
        private string name { get; set; } // Nombre del personaje
        private string element { get; set; } // Elemnto del persona

        //TODO: LISTA DE PERSONAJES
        private List<Person> charaList = new List<Person>(); //Lista para almacenar multiples personajes

        //TODO: CONSTRUCTORES

        //Nivel Publico: Donde todas las Clases pueden usar este constructor, que NO TIENE ATRIBUTOS
        public Person ()
        { }

        //Nivel Privado: Donde lo usaremos de forma INTERNA. Que contiene ATRIBUTOS.
        private Person (string n, string e)
        {
            name = n;
            element = e;
            #region EXPLICACIONES
            //En este caso, se puede usar el this o no usarlo, ya que se diferencia los nombre de los atributos con los parametros.
            //Se puede poner de las dos formas.
            /*
             * Se puede usar asi tambien:
             * this.name = n;
             * this.element = e;
             */

            #endregion
        }


        //TODO: METODOS

        // Añadir Personaje
        public void AddCharacter (string nom, string elt)
        {
            //Creamos el objeto de tipo: Person, en el cual le pasamos los parametros que tenemos en el metodo
            Person newCharacte = new Person( nom, elt );

            //Añadimos el personaje a la lista:

            charaList.Add( newCharacte );

            //Notificamos que se ha añadido el personaje a la lista
            Console.WriteLine( $"Personaje {nom} de elemento: {elt} añadido con exito a la lista." );
        }


        //Mostrar datos del personaje
        public void ShowChara ()
        {
            int count = 1; //Contador para mostrar el numero de personaje.
            if ( charaList.Count == 0 )
            {
                Console.WriteLine( "No hay ningun  personaje a mostrar" ); //Notificamos 
                return; // Salimos del metodo en caso de que haya personajes en la lista
            }

            Console.WriteLine();
            Console.WriteLine( "Personajes en la lista: " );
            foreach ( var chara in charaList )
            {
                Console.WriteLine( $"Personaje {count++}:  \n -Nombre del personaje: {chara.name} " +
                    $"\n -Elemento del personaje: {chara.element} " );
                Console.WriteLine();

            }
        }


        public void DeleteCharacter (string nom)
        {
            //Buscar el personaje por el nombre
            Person? charaRev = null;
            foreach ( var chara in charaList )
            {
                if ( chara.name.Equals( nom ) )
                {
                    charaRev = chara; //Asignamos el personaje a la variable charaRev
                }
            }

            if ( charaRev != null )
            {
                charaList.Remove( charaRev ); //Eliminamos el personaje de la lista
                Console.WriteLine( $"Personaje {charaRev.name} eliminado con exito de la lista." );

            }
            else
            {
                Console.WriteLine( $"El personaje {nom} no se encuentra en la lista." );
            }

        }

    }
}



