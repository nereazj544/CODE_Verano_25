using Solucion_Cal_2_2.Class;

class Program {
    static void Main ()
    {
        Run();
    }
    public static  void Run ()
    {
        bool _exit = false;

        while (!_exit)
        {

        MenuCMD menu = new MenuCMD();

        menu.ShowMenu();
        Console.Write("Respuesta (numero 1-5):  ");
        string r ;
        r = Console.ReadLine();
        menu.MenuRespuesta( r );
            if (r == "5")
            {
                _exit = true; // Finalizar el programa
            }
        }

        
    }
}