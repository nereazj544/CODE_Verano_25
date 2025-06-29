

//TODO: 1 . Diferencias enre WriteLine y Wirte

Console.WriteLine("¡Hola, Mundo!");
Console.WriteLine("C# es un lenguaje de programación orientado a objetos.");
Console.Write("SIN ENTER AL FINAL");
Console.Write("SIN ENTER AL FINAL");



Console.WriteLine("\n ================= \n");  // La "\n" es para saltar una línea


//TODO: 2. MESNAJES Y LEER INFORMACION POR CONSOLA

Console.WriteLine("¿Cual es tu nombre?"); //Solicitar el nombre
string name = Console.ReadLine(); //Recibir el nombre
Console.WriteLine($"¿Tu nombre es: {name}? (s/n)"); //Preguntar si es correcto
string respuesta = Console.ReadLine(); //Recibir la respuesta

//Flujo de control If-Else 
if (respuesta.Equals("s")) //Comprobar si la respuesta es "s"
{
    Console.WriteLine($"Bienvenid@ {name}");
}
else if(respuesta.Equals("n")) //Comprobar si la respuesta es "n"
{
    Console.WriteLine("¿Cual es tu nombre?"); //Solicita de nuevo el nombre
    name = Console.ReadLine(); //Recibe el nuevo nombre
    Console.WriteLine($"Bienvenid@ {name}");
} else //En caso de que la respuesta no sea "s" o "n"
{
    Console.WriteLine("Respuesta no válida. Por favor, responde con 's' o 'n'."); 
    //Es un mensaje por defecto
}