Console.Clear();  // 1) Borrar la pantalla.

Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();    //  2) Pedir el nombre de una persona.

Console.WriteLine("¡Hola " + nombre + "!");     // 3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"

Console.Write("¿Desea continuar? (S/N) :");   //4) Preguntar si se quiere continuar.
string respuesta = Console.ReadLine();

while (respuesta.ToUpper()=="S")
{
    Console.Clear();
     Console.Write("Ingrese su nombre: ");
    nombre = Console.ReadLine();
    Console.WriteLine("¡Hola " + nombre + "!");
    Console.Write("¿Desea continuar? (S/N) :");   // 5) Si la respuesta es "S" repetir desde el punto 1.
    respuesta = Console.ReadLine(); 

}
while(respuesta.ToUpper() != "S" && respuesta.ToUpper() != "N")
    {
        Console.WriteLine("La opcion elegida no es valida. El programa finalizó.");
    break;

    }

Console.WriteLine("Programa finalizado correctamente.");

