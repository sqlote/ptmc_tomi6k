// Do While bucle
string opcionElegida;
do
{
    Console.Clear();
    Console.Write("¡Buenas! Ingrese su nombre: ");
    var nombrePersona = Console.ReadLine();

    Console.WriteLine($"Hola {nombrePersona}");
    Console.Write("¿Desea Continuar? (Si o No) :");
    opcionElegida = Console.ReadLine();

    if (opcionElegida.ToUpper() == "N")
    {
        Console.WriteLine("Programa Finalizado correctamente.");
    }
    else if (opcionElegida.ToUpper() != "S")
    {
        Console.WriteLine("Opcion no valida.");
    }
} while (opcionElegida.ToUpper() == "S");