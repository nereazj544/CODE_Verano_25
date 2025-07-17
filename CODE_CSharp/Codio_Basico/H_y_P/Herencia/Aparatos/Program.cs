using Aparatos.Clases;

class Program
{
    static void Main ()
    {
        Lavadora l = new Lavadora();
        l.SetRMP( 1200 );
        l.SetKg( 7 );
        l.Encendido();
        l.SetTension( 200 );
        l.Datos();
        Console.WriteLine( "\n\n" );
    }
}