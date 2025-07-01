//LIBRERIAS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ESAPCIO DE TRABAJO (NOMBRE PROTECTO > CARPETA CONTENEDORA) 
namespace Basci4_Class.Class
{
    public class Persona  // Esta clase es de tipo PUBLICO porque queresmos que TODAS las clases puedan acceder a ella
    {
        //PROPIEDADES (ATRIBUTOS) Propiedades auto-implementadas
        private string name { get; set; }  //Nombre de la persona que es de tipo STRING y es private.
        private int age { get; set; }   //Edad de la persona que es de tipo INT y es private.

        //MULTIPLES PERSONAS

        private List<Persona> personasList = new List<Persona>(); //Lista para almacenar multiples personas, adtualmente esta vacia

        //CONSTRUCTORES
        public Persona()
        { }

        //Constructor con parametros que se usara internamente para crear a las personas
        private Persona(string nombre, int edad)
        {
            this.name = nombre;
            this.age = edad;
        }

        //TODO: Metodos Añadir Personas
        public void addPerson(string nombre, int edad)
        {
            this.name = nombre;  //Asignamos el nombre a la propiedad name de la clase: Persona
            this.age = edad;  //Asignamos la edad a la propiedad age de la clase: Persona
        }

        public void addpersonList(string nombre, int edad)
        {
            Persona newPerson = new Persona(nombre, edad);
            personasList.Add(newPerson); //añadir persona a la lista
            Console.WriteLine($"Persona {nombre} añadida a la lista.");

        }


        //TODO: Metodo de mostrar datos de la persona
        public void MostrarDatos()
        {
            Console.WriteLine($" - Nombre: {name} \n - Edad: {age}");
        }

        public void MostrarDatosList()
        {
            if (personasList.Count == 0)
            {
                Console.WriteLine("No hay persoanas disponibles en la lista.");
                return;  // Salimos del metodo en caso de que si haya personas en la lista
            }
            Console.WriteLine("Personas en la lista:");
            int count = 1;
            foreach (var per in personasList)
            {
                Console.WriteLine($"Datos persona n {count++}");
                per.MostrarDatos();
            }
        }

    }
}
