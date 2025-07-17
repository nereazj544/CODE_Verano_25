
class Program
{
    static void Main()
    {
        Bucle_Ej1();
        Console.WriteLine();
        Bucle_Ej2();
    }



    private static void Bucle_Ej1()
    {
        Console.WriteLine("Matriz de 10x10 con números del 0 al 99:");
        Console.WriteLine();
        for (int fl = 0; fl < 10; fl++)
        {
            for (int col = 0; col < 10; col++)
            {
                int num = fl * 10 + col;
                Console.Write($"{num,3}"); // el 3 es para alinear el num en 3 espacios
            }
            Console.WriteLine();
        }

    }

    private static void Bucle_Ej2()
    {
        bool isCorrect = false;
        Console.WriteLine("Escribe la palabra correcta: ");

        do
        {
            string secretWord = Console.ReadLine().ToLower();

            if (secretWord.Equals("abracadabra"))
            {
                Console.WriteLine($"Tu: {secretWord}");
                Console.WriteLine($"Yo: ¡Pata de cabra!");
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Intentalo de nuevo. Escribe la palabra correcta: ");
                
            }

        } while (!isCorrect);
    }
}