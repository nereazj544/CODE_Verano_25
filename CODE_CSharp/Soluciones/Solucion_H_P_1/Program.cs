using Solucion_H_P_1.Class;

class Program{
    static void Main ()
    {
        Guerrero g;

        Console.WriteLine("Nombre del Personaje");
        string nombre = Console.ReadLine();
        Console.WriteLine("Rol: Mago, Guerrero o Arquero");
        string rol = Console.ReadLine();
        rol = rol.ToUpper();

        switch ( rol )
        {
            case "Guerrero":
                Console.WriteLine($"Guerrero: {nombre}" );
                Console.WriteLine( "Nivel: " );
                int nv = int.Parse( Console.ReadLine() );
                Console.WriteLine( "Puntos de vida: " );
                int pv = int.Parse( Console.ReadLine() );
                Console.WriteLine( "Fuerza: " );
                int fuerza = int.Parse( Console.ReadLine() );
                Console.WriteLine( "Resistencia: " );
                int resistencia = int.Parse( Console.ReadLine() );
                g = new Guerrero( nombre, pv, nv, fuerza, resistencia );
                Console.WriteLine($"Estadisticas del Guerrero: " +
                    $"\n \t-Nivel:{nv} \n \t-Puntos de Vida:{pv}" );

                break;
            case "Mago":
                Console.WriteLine($"Mago: {nombre}");
                break;
            case "Arquero":
                Console.WriteLine($"Arquero: {nombre}");
                break;
        }

        


    }


}
