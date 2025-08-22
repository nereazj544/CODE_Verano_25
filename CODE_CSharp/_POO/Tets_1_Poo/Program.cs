<<<<<<< HEAD
﻿using Tets_1_Poo;

class Program
{
    static void Main ()
    {
        Console.WriteLine( "¿Cual es tu nombre?" );
        string  nombre = Console.ReadLine();
        Console.WriteLine( "¿Cual es tu edad?" );
        int  edad = Convert.ToInt32(Console.ReadLine());

        
        Person pr = new Person(nombre, edad);
        pr.Mostrar();


        /*
        Person pr = new Person("Neo", 20);
        Person pr1 = new Person("Kai", 5); 
        pr.Mostrar();
        pr1.Mostrar();
        */
        //! Sin constructor
        //pr.Name = "Neo";
        //pr.edad = 20;

       
    }
=======
﻿using Tets_1_Poo;

class Program
{
    static void Main ()
    {
        Console.WriteLine( "¿Cual es tu nombre?" );
        string  nombre = Console.ReadLine();
        Console.WriteLine( "¿Cual es tu edad?" );
        int  edad = Convert.ToInt32(Console.ReadLine());

        
        Person pr = new Person(nombre, edad);
        pr.Mostrar();


        /*
        Person pr = new Person("Neo", 20);
        Person pr1 = new Person("Kai", 5); 
        pr.Mostrar();
        pr1.Mostrar();
        */
        //! Sin constructor
        //pr.Name = "Neo";
        //pr.edad = 20;

       
    }
>>>>>>> ffbac04138a85568f4d522e49aac8391c3104c35
}