using Aparatos.Clases;

class Program
{
    static void Main ()
    {
        Lavadora l = new Lavadora(); //Inicializamos el objeto de la clase lavadora
        //clases Lavadora 
        l.SetRMP( 1200 );
        l.SetKg( 7 );


        //Clase Lavadora hereda de Electrodomestico, por lo que podemos usar sus métodos
        l.Encendido();
        l.SetTension( 200 );

        l.Datos(); // Datos son de la clases Lavadora

        Console.WriteLine( "\n\n" );
    }
}