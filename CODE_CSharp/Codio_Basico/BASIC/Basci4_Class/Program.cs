using Basci4_Class.Class;

class Program
{
    static void Main()
    {
        int contador = 1;
        /*
        Persona pr = new Persona(); //Creamos el objeto de la clase: Persona
        Persona pr2 = new Persona(); //Creamos el objeto de la clase: Persona
        Persona pr3 = new Persona(); //Creamos el objeto de la clase: Persona
        */

        //TODO: CUANDO LOS ATRIBUSTOS SON PUBLICOS
        //pr.name = "Neo";
        //pr.age = 20;


        //TODO: CUANDO LOS ATRIBUTOS SON PRIVADOS, TENEMOS UN METODO PARA AÑADIR PERSONAS
        /*
         * 
        pr.addPerson("Neo", 20);
        pr2.addPerson("Kai", 5);
        pr3.addPerson("Akira", 29);

        //TODO: Mostrar los datos de las personas
        Console.WriteLine("METODO 1: MOSTAR DATOS");
        pr.MostrarDatos();
        pr2.MostrarDatos();
        */

       /*
       Console.WriteLine("METODO 2: MOSTAR DATOS");
       for(int i = 0; i < 3; i++)
       {
           Console.WriteLine($"Datos persona n {contador++}");
           pr.MostrarDatos();
           pr2.MostrarDatos();
           pr3.MostrarDatos();
       }

       Console.WriteLine("METODO 2: MOSTAR DATOS");*/
        //TODO: Una manera de mostrar los datos
        /*foreach (var item in new List<Persona> { pr, pr2, pr3 })
        {
            Console.WriteLine($"Datos persona n {contador++}");
            item.MostrarDatos();
        }*/

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


    }
}