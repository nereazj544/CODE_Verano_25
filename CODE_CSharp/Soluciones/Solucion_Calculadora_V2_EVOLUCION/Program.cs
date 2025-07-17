using System.ComponentModel;

class Program
{
    static void Main(String[] args)
    {
        Menu();


    }

    private static void Menu()
    {
        bool exit = false; //Variable para controlar la salida del bucle
        do
        {
            //Mostar mensajes de comandos
            Console.WriteLine("\n== CALCULADORA _ SOLCUION ==\n");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");


            Console.Write("Respuesta: ");
            //Leer la opcion del usuario
            int cmd = Convert.ToInt32(Console.ReadLine());

            switch (cmd)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    Restar();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 5:
                    exit = true; //FINALIZAR EL PROGRAMA
                    Console.WriteLine(". . . SALIENDO DEL PROGRAMA . . .");
                    break;
                default:
                    Console.WriteLine("OPCION INVALIDA, POR FAVOR INGRESE UNA OPCION VALIDA (1-5)");
                    exit = true; //FINALIZAR EL PROGRAMA
                    break;
            }

        } while (!exit);
    }

    private static void Sumar()
    {
        int nm_1;
        int nm_2;
        int r;
        Console.WriteLine($"OPCION - SUMAR");
        Console.Write("Primer nuemero. Respuesta: ");
        nm_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo nuemero. Respuesta: ");
        nm_2 = Convert.ToInt32(Console.ReadLine());
        r = nm_1 + nm_2;
        Console.Write($"Resultado de la suma: {nm_1} + {nm_2} = {r}");
        Menu();
    }
    private static void Restar()
    {
        int nm_1;
        int nm_2;
        int r;
        Console.WriteLine($"OPCION - RESTAR");
        Console.Write("Primer nuemero. Respuesta: ");
        nm_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo nuemero. Respuesta: ");
        nm_2 = Convert.ToInt32(Console.ReadLine());
        r = nm_1 - nm_2;
        Console.Write($"Resultado de la suma: {nm_1} - {nm_2} = {r}");
        Menu();

    }
    private static void Multiplicar()
    {
        int nm_1;
        int nm_2;
        int r;
        Console.WriteLine($"OPCION - MULTIPLICAR");
        Console.Write("Primer nuemero. Respuesta: ");
        nm_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo nuemero. Respuesta: ");
        nm_2 = Convert.ToInt32(Console.ReadLine());
        r = nm_1 * nm_2;
        Console.Write($"Resultado de la suma: {nm_1} * {nm_2} = {r}");
        Menu();
    }
    private static void Dividir()
    {
        int nm_1;
        int nm_2;
        int r;
        Console.WriteLine($"OPCION - MULTIPLICAR");
        Console.Write("Primer nuemero. Respuesta: ");
        nm_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo nuemero. Respuesta: ");
        nm_2 = Convert.ToInt32(Console.ReadLine());
        r = nm_1 / nm_2;
        Console.Write($"Resultado de la suma: {nm_1} / {nm_2} = {r}");
        Menu();
    }
}