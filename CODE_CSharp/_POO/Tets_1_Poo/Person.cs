using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tets_1_Poo
{
    class Person
    {
        public string Name { get; set; }
        public int  edad { get; set; }

        //== CONSTRUCTOR ==
        public Person(string nombre, int age)
        {
        Name = nombre;
            edad = age;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Name}, Edad: {edad}");
        }

    }
}
