using Basci4_Class.Class;


class Program
{
    static void Main ()
    {
        Person chara = new Person(); //Objeto de la clase Person, la cual es el constructor PUBLICO.
        bool isExit = false; //Boleano para salir del programa.

        Console.WriteLine( " Bienvenido al gestor de personajes: " );

        while ( !isExit )
        {
            Console.WriteLine( " OPCIONES:  " );
            Console.WriteLine( " 1 - Insertar personajes " );
            Console.WriteLine( " 2 - Mostrar personajes " );
            Console.WriteLine( " 3 - Eliminar " );
            Console.WriteLine( " 4 - Salir " );
            Console.Write( "\nRespuesta (numero):  " );

            int cmd = Convert.ToInt32( Console.ReadLine() );
            switch ( cmd )
            {
                case 1:
                    Console.WriteLine( "Insertar personajes" );
                    InsertChara( chara );
                    break;
                case 2:
                    Console.WriteLine( "Mostrar personajes" );
                    chara.ShowChara(); //Mostramos los personaje que se han añadido a la lista
                    break;

                case 3:
                    Console.WriteLine( "Eliminar personajes" );
                    Console.WriteLine( "Nombre del personaje a borrar " );
                    Console.Write( "Nombre: " );
                    string n = Console.ReadLine();
                    chara.DeleteCharacter( n ); //Llamamos al metodo de elimnar personaje, pasandole el nombre
                    break;
                case 4:
                    Console.WriteLine( "Salir del programa" );
                    isExit = true; //Cambiamos el valor del booleano a true para salir del programa.
                    break;

                default:
                    Console.WriteLine( "OPCION NO VALIDA." );
                    break;

            }
        }


        #region EJEMPLO 1: CLASS PERSONA
        /*
        int contador = 1;
        
        Persona pr = new Persona(); //Creamos el objeto de la clase: Persona
        Persona pr2 = new Persona(); //Creamos el objeto de la clase: Persona
        Persona pr3 = new Persona(); //Creamos el objeto de la clase: Persona
        

        //TODO: CUANDO LOS ATRIBUSTOS SON PUBLICOS
        //pr.name = "Neo";
        //pr.age = 20;


        //TODO: CUANDO LOS ATRIBUTOS SON PRIVADOS, TENEMOS UN METODO PARA AÑADIR PERSONAS
        
        pr.addPerson("Neo", 20);
        pr2.addPerson("Kai", 5);
        pr3.addPerson("Akira", 29);

        //TODO: Mostrar los datos de las personas
        Console.WriteLine("METODO 1: MOSTAR DATOS");
        pr.MostrarDatos();
        pr2.MostrarDatos();
      
       Console.WriteLine("METODO 2: MOSTAR DATOS");
       for(int i = 0; i < 3; i++)
       {
           Console.WriteLine($"Datos persona n {contador++}");
           pr.MostrarDatos();
           pr2.MostrarDatos();
           pr3.MostrarDatos();
       }

       Console.WriteLine("METODO 2: MOSTAR DATOS");
        //TODO: Una manera de mostrar los datos
       *foreach (var item in new List<Persona> { pr, pr2, pr3 })
        {
            Console.WriteLine($"Datos persona n {contador++}");
            item.MostrarDatos();
        }

        Persona pr_List = new Persona();

        pr_List.addpersonList("Neo", 20);
        pr_List.addpersonList("Kai", 5);
        pr_List.addpersonList("Igor", 24);

        Console.WriteLine("Inserta un nomrbe. ");
        Console.Write("RESPUESTA: ");
        string name = Console.ReadLine();

        Console.WriteLine("Inserta una edad. ");
        Console.Write("RESPUESTA: ");
        int age = Convert.ToInt32(Console.ReadLine());

        pr_List.addpersonList(name, age);

        pr_List.MostrarDatosList();

        */
        #endregion
    }

    private static void InsertChara (Person chara)
    {
        Console.WriteLine( "\n¿Quieres añadir los personajes por defecto, nuevos? (defecto/nuevos/ambos)" );
        Console.Write( "Comando: " );

        string cmd = Console.ReadLine();


        switch ( cmd.ToLower() )
        {
            case "defecto":
                Console.WriteLine( "Añadiendo personajes por defecto..." );
                // Aquí puedes añadir los personajes por defecto
                chara.AddCharacter( "Phainon", "Fisico" );
                chara.AddCharacter( "Mydei", "Imaginario" );
                chara.AddCharacter( "Tribbie", "Cuantico" );
                chara.AddCharacter( "Anaxa", "Viento" );
                chara.AddCharacter( "Ceridra", "Viento" );
                chara.AddCharacter( "Sunday", "Imaginario" );
                break;

            case "nuevos":
                AddNewChara( chara );
                break;
            case "ambos":
                Console.WriteLine( "Añadiendo primero los personajes por defecto: " );
                chara.AddCharacter( "Phainon", "Fisico" );
                chara.AddCharacter( "Mydei", "Imaginario" );
                chara.AddCharacter( "Tribbie", "Cuantico" );
                chara.AddCharacter( "Anaxa", "Viento" );
                chara.AddCharacter( "Ceridra", "Viento" );
                chara.AddCharacter( "Sunday", "Imaginario" );
                Console.WriteLine( "Personajes por defecto añadidos con exito." );
                Console.WriteLine( "Personajes pro defecto: " );
                chara.ShowChara(); //Mostramos los personajes que se han añadido a la lista
                Console.WriteLine( "Ahora puedes añadir nuevos personajes: " );

                AddNewChara( chara );
                break;
            default:
                Console.WriteLine( $"El comando: '{cmd}' no esta reconocido." );
                break;


        }

    }

    private static void AddNewChara (Person chara)
    {
        bool isContinueAddChara = true;
        while ( isContinueAddChara )
        {
            Console.WriteLine( "Añadir nuevo personaje" );
            string name = Console.ReadLine();

            Console.WriteLine( "Añadir elemento del personaje" );
            string element = Console.ReadLine();



            //Añadimos el personaje a la lista
            chara.AddCharacter( name, element );

            Console.WriteLine( "¿Quieres añadir otro personaje? (s/n)" );
            string cmd = Console.ReadLine().ToLower();
            //No continua añadiendo personajes.
            if ( cmd.Equals( "n" ) || cmd.Equals( "no" ) )
            {
                isContinueAddChara = false;
                Console.WriteLine( "Lista actualizada\n" );
            }
        }
    }

   

}