using Solucion_H_P_1.Class;
using Solucion_H_P_1.Class.Combate;
using Solucion_H_P_1.Class.Roles;

class Program{
    static void Main ()
    {
      
        Personaje chara;

        Console.WriteLine("Nombre del Personaje");
        string nombre = Console.ReadLine();
        Console.WriteLine("Rol: Mago, Guerrero o Arquero");
        string rol = Console.ReadLine();
        // rol = rol.ToUpper();

        if ( !string.IsNullOrEmpty( rol ) )
        {
            rol = char.ToUpper( rol[0] ) + rol.Substring( 1 ).ToLower(); //Capitaliza la primera letra
        }

        switch ( rol )
        {
            case "Guerrero":
                Console.Write($"Guerrero: {nombre} \n" );
                Console.Write( "Nivel: " );
                int nv_g = int.Parse( Console.ReadLine() );
                Console.Write( "Puntos de vida: " );
                int pv_g = int.Parse( Console.ReadLine() );
                Console.Write( "Fuerza: " );
                int fuerza_g = int.Parse( Console.ReadLine() );
                Console.Write( "Resistencia: " );
                int resistencia = int.Parse( Console.ReadLine() );
                chara = new Guerrero( nombre, pv_g, nv_g, fuerza_g, resistencia );
                Console.WriteLine( $"Estadísticas del Guerrero {nombre}:" +
                     $"\n\t- Nivel: {nv_g}" +
                     $"\n\t- Puntos de Vida: {pv_g}" +
                     $"\n\t- Fuerza: {fuerza_g}" +
                     $"\n\t- Resistencia: {resistencia}" );

                break;

            case "Mago":
                Console.WriteLine($"Mago: {nombre}");
                
                Console.Write( "Nivel: " );
                int nv_m = int.Parse( Console.ReadLine() );
                Console.Write( "Puntos de vida: " );
                int pv_m = int.Parse( Console.ReadLine() );
                Console.Write( "Fuerza: " );
                int fuerza_m = int.Parse( Console.ReadLine() );
                Console.Write( "mana: " );
                int mana = int.Parse( Console.ReadLine() );
                chara = new Mago( nombre,pv_m, nv_m, fuerza_m, mana);
                Console.WriteLine( $"Estadísticas del Mago {nombre}:" +
                     $"\n\t- Nivel: {nv_m}" +
                     $"\n\t- Puntos de Vida: {pv_m}" +
                     $"\n\t- Fuerza: {fuerza_m}" +
                     $"\n\t- Mana: {mana}" );
                break;

            case "Arquero":
                Console.Write($"Arquero: {nombre}");
                Console.Write( "Nivel: " );
                int nv_a = int.Parse( Console.ReadLine() );
                Console.Write( "Puntos de vida:  " );
                int pv_a = int.Parse( Console.ReadLine() );
                Console.Write( "Fuerza:  " );
                int fuerza_a = int.Parse( Console.ReadLine() );
                Console.Write( "Presicion:  " );
                int pc = int.Parse( Console.ReadLine() );
                chara = new Mago( nombre, pv_a, nv_a, fuerza_a, pc );
                Console.WriteLine( $"Estadísticas del Arquero {nombre}:" +
                     $"\n\t- Nivel: {nv_a}" +
                     $"\n\t- Puntos de Vida: {pv_a}" +
                     $"\n\t- Fuerza: {fuerza_a}" +
                     $"\n\t- Resistencia: {pc}" );
                break;

            default:
                Console.WriteLine("Rol desconocido.");
                break;
        }

        
       

    }


}
