

//TODO: 1 . Diferencias enre WriteLine y Wirte

using System.Numerics;

Console.WriteLine("¡Hola, Mundo!");
Console.WriteLine("C# es un lenguaje de programación orientado a objetos.");
Console.Write("SIN ENTER AL FINAL");
Console.Write("SIN ENTER AL FINAL");



Console.WriteLine("\n ================= \n");  // La "\n" es para saltar una línea


//TODO: 2. CONCATENACION DE CADENAS
string name_1 = "Ejemplo";

Console.WriteLine($"Nombre: {name_1}"); // Usando $ 
Console.WriteLine("Nombre: " + name_1); // Usando +
Console.WriteLine("Nombre: {0}", name_1); // Usando el numero de indice
                                          // (empieza desde el 0, 1, 2, 3....40)
Console.WriteLine(format: "Nombre: {0}", name_1); // Usando el formato de cadena



//TODO: 3. MESNAJES Y LEER INFORMACION POR CONSOLA

Console.WriteLine("¿Cual es tu nombre?"); //Solicitar el nombre
string name = Console.ReadLine(); //Recibir el nombre
Console.WriteLine($"¿Tu nombre es: {name}? (s/n)"); //Preguntar si es correcto
string respuesta = Console.ReadLine(); //Recibir la respuesta

//Flujo de control If-Else 
if (respuesta.Equals("s")) //Comprobar si la respuesta es "s"
{
    Console.WriteLine($"Bienvenid@ {name}");
}
else if (respuesta.Equals("n")) //Comprobar si la respuesta es "n"
{
    Console.WriteLine("¿Cual es tu nombre?"); //Solicita de nuevo el nombre
    name = Console.ReadLine(); //Recibe el nuevo nombre
    Console.WriteLine($"Bienvenid@ {name}");
}
else //En caso de que la respuesta no sea "s" o "n"
{
    Console.WriteLine("Respuesta no válida. Por favor, responde con 's' o 'n'.");
    //Es un mensaje por defecto
}


// TODO: 4. OPERADORES LOGICOS
Console.WriteLine("\n ================= \n");

//Numeros a comprobar

// int n1 = 13; //NO SE CUMPLE LA CONDICION PORQUE NO ES MAYOR O IGUAL A 18,
//POR LO TANTO NO ES UN ADULTO (FALSE)

int n1 = 20; //SE CUMPLE LA CONDICION PORQUE ES MAYOR O IGUAL A 18,
             //POR LO TANTO ES UN ADULTO (TRUE)

bool isAdult = true; //Edad minima para ser adulto

if (n1 >= 18 && isAdult)
{
    Console.WriteLine($"ES UN ADULTO, EDAD: {n1}");
}
else
{
    Console.WriteLine($"NO SE CUMPLE LA CONDICION, PORQUE SU EDAD ES DE: {n1}");
}


// TODO: 5. ARRAYS

Console.WriteLine("\n ================= \n");

string[] textoArray = { "hola", "mundo", "dksa" };
int[] numerosArray = { 1, 12, 34, 56 };

string lenguajes_listas = "C# PYTHON JAVA HTML CSS";
string[] lenguajes = lenguajes_listas.Split(' '); //Separar la cadena en un array
Console.WriteLine("Lenguajes de Programación:");
Console.WriteLine(lenguajes[0]); // 0: C#
Console.WriteLine(lenguajes[1]); // 1: PYTHON
Console.WriteLine(lenguajes[2]); // 2: JAVA
Console.WriteLine(lenguajes[3]); // 3: HTML
Console.WriteLine(lenguajes[4]); // 4: CSS

char[] separadores = { ',' };

string lenguajes_listas2 = "C#, PYTHON, JAVA, HTML, CSS";
string[] lenguajes_2 = lenguajes_listas2.Split(separadores); //Separar la cadena en un array
Console.WriteLine($"Cadena Original: {lenguajes_listas2}");
Console.WriteLine("Lenguajes de Programación:");
Console.WriteLine(lenguajes_2[0]); // 0: C#
Console.WriteLine(lenguajes_2[1]); // 1: PYTHON
Console.WriteLine(lenguajes_2[2]); // 2: JAVA
Console.WriteLine(lenguajes_2[3]); // 3: HTML
Console.WriteLine(lenguajes_2[4]); // 4: CSS

int[] enteros = { 1, 2, 3 };
Console.WriteLine("Array de enteros (Original):" + enteros[0] + ", " + enteros[1] + ", " + enteros[2]);

Console.WriteLine("¿Existe el elemento: 10?" + Array.IndexOf(enteros, 10));
// Comprobar si existe el elemento 10 en el array
Console.WriteLine("¿Existe el elemento: 2? " + Array.IndexOf(enteros, 2));
// Comprobar si existe el elemento 2 en el array

enteros[2] = 80; //cambiar valor de la posicion 9 del array

Console.WriteLine("Array de enteros:" + enteros[0] + ", " + enteros[1] + ", " + enteros[2]);
Array.Sort(enteros);
Console.WriteLine("Array de enteros (Ordenado):" + enteros[0] + ", " + enteros[1] + ", " + enteros[2]);
Array.Reverse(enteros);
Console.WriteLine("Array de enteros (Invertido):" + enteros[0] + ", " + enteros[1] + ", " + enteros[2]);

// TODO: LISTAS
List<int> numerosList = new List<int> { 1, 2, 3 };
numerosList.Add(5); // Añadir
List<string> textoList = new List<string> { "hola", "mundo", "dksa" };

textoList.Remove("hola"); // Elimina el elemento que se especifique por parametro
Console.WriteLine("Numero de elementos en la lista: " + numerosList.Count);
//cuenta los elementos de la lista

numerosList.RemoveAt(2); //Elimina el indice que se expecifique por parametro

List<List<int>> listaDeListas = new List<List<int>>
{ new List<int> { 1,2,3}, new List<int> { 23, 80, 90} }; //Lista de listas 
Console.WriteLine("Lista de listas: " + listaDeListas[0][0] +
    ", " + listaDeListas[0][1] + ", " + listaDeListas[0][2]);

//DICCIONARIOS

Dictionary<string, int> diccionario = new Dictionary<string, int>();

diccionario.Add("C#", 1);

Dictionary<string, string> diccionario2 = new Dictionary<string, string>();

diccionario2.Add("C#", "Lenguaje de Programación");

Console.WriteLine("Dicionario Key:" + diccionario2.ContainsKey("C#"));


//TODOO: 6. Flujos de control

Console.WriteLine("\n ================= \n");

Console.WriteLine("¿Que temperatura hace?"); //Solicitar la temperatura

int temp = Convert.ToInt32(Console.ReadLine()); //El Convert.ToInt32 convierte el valor de la cadena
                                                //a un entero (en otras palabras: Sirve pa meter numeros)

if (temp < 0)
{
    Console.WriteLine("Hace frio, ponte la manta");
}
else
{
    Console.WriteLine("Hace calor, quitate la manta y tirate a la piscina");
}


// SWITCH

Console.WriteLine("\n ================= \n");

Console.WriteLine("¿Que lados tiene tu figura?"); //Solicitar los lados 

int lados = Convert.ToInt32(Console.ReadLine());
string figura;
/*
if (lados == 3)
{
    figura = "Triángulo";
    Console.WriteLine($"La figura con {lados} lados es un {figura}");
} else if (lados == 4)
{
    figura = "Cuadrado";
    Console.WriteLine($"La figura con {lados} lados es un {figura}");
}
else if (lados == 5)
{
    figura = "Pentágono";
    Console.WriteLine($"La figura con {lados} lados es un {figura}");
}
else
{
    figura = "Figura desconocida";
    Console.WriteLine($"La figura con {lados} lados es una {figura}");
}
*/

switch (lados)
{
    case 3:
        figura = "Triángulo";
        Console.WriteLine($"La figura con {lados} lados es un {figura}");
        break;
    case 4:
        figura = "Cuadrado";
        Console.WriteLine($"La figura con {lados} lados es un {figura}");
        break;
    case 5:
        figura = "Pentágono";
        Console.WriteLine($"La figura con {lados} lados es un {figura}");
        break;
    default:
        figura = "Figura desconocida";
        Console.WriteLine($"La figura con {lados} lados es una {figura}");
        break;

}

// TODO: 7. BUCLES

Console.WriteLine("\n ================= \n");
bool fin = false; //finalizar el bucle

int contador = 0;

while (!fin)
{
    Console.WriteLine($"Iteración número: {contador}");

    contador++; //incrementea el conrador

    // Verificar condición de salida
    if (contador >= 5)
    {
        fin = true;
        Console.WriteLine("Bucle terminado");
    }
   
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Iteración número: {i}");
   
}

List<int> numerosList_2 = new List<int>() { 1, 2, 3 };
foreach (var item in numerosList_2)
{
    Console.WriteLine($"Numero: {item}" );
}


do
{
   int contador_2 = 0;
    Console.WriteLine($"Iteración número: {contador_2}");

    contador_2++; //incrementea el conrador

    // Verificar condición de salida
    if (contador_2 >= 5)
    {
        fin = true;
        Console.WriteLine("Bucle terminado");
    }

} while (!fin);


Console.WriteLine("\n Comportamiento de cadenas: \n");
string texto = "Hola, mundo";
texto = texto.ToUpper(); //Convierte el texto (completo) a MAYUSCULAS
Console.WriteLine(texto);
texto = texto.ToLower(); //Convierte el texto (completo) a minusculas
Console.WriteLine(texto);

texto = texto.Replace("mundo", "c#"); //Reemplaza una palabra por otra
Console.WriteLine(texto);

texto = texto.Trim();//Elimina los espacios en blanco al principio y al final del texto
Console.WriteLine(texto);

texto = texto.TrimEnd(); //Elimina los espacios en blanco al final del texto
Console.WriteLine(texto);
texto = texto.TrimStart(); //Elimina los espacios en blanco al principio del texto
Console.WriteLine(texto);
string concat_Method = string.Concat("Hola ", "Mundo"); // "Hola Mundo"
Console.WriteLine(concat_Method);
string mensaje = string.Format("Hola {0}, tienes {1} años", "Juan", 25);
// "Hola Juan, tienes 25 años"
Console.WriteLine(mensaje);

bool resultado_Star = "Hola Mundo".StartsWith("Hola"); // true
Console.WriteLine(resultado_Star);
bool resultado_End = "Hola Mundo".EndsWith("Mundo"); // true
Console.WriteLine(resultado_End);

