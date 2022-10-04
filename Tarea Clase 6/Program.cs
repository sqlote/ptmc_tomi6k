  Console.Clear();
// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

int intentos = 0;
int numero;
Console.WriteLine("¡Hola! la computadora generó un nuevo aleatorio entre 1 y 20, ¿serás capaz de adivinarlo?");
do
{
    // Pedimos que ingrese un numero    

    Console.Write("¿Que numero crees que genero la computadora? ");
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    bool igual = numero == numeroSecreto;
    bool menor = numero < numeroSecreto;
    bool mayor = numero > numeroSecreto;
    bool desigual = numero > 20;    


    if (igual)
    {
        Console.WriteLine("");
        intentos++;
        Console.WriteLine($"¡Has adivinado!, el numero es: {numeroSecreto}");
        Console.WriteLine("");
        Console.WriteLine($"Lo hiciste en {intentos} intentos.");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ReadKey();
        Console.WriteLine("----------------------------------------------------");

    }
    else if (desigual)
    {
        Console.WriteLine("");
        intentos++;
        Console.WriteLine("El numero ingresado no es valido, coloca un numero entre 1 y 20");
        Console.WriteLine("");
        Console.WriteLine($"Prueba de nuevo, lo has intentado: {intentos} veces");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------");
    }
    else if (menor)
    {
        Console.WriteLine("");
        intentos++;
        Console.WriteLine("¡El numero que ingresaste es menor al numero secreto!");
        Console.WriteLine("");
        Console.WriteLine($"Prueba de nuevo, lo has intentado: {intentos} veces");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------");

    }
    else if (mayor)
    {
        Console.WriteLine("");
        intentos++;
        Console.WriteLine("¡El numero que ingresaste es mayor al numero secreto");
        Console.WriteLine("");
        Console.WriteLine($"Prueba de nuevo, lo has intentado: {intentos} veces");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------");

    }
    

} while (numero != numeroSecreto);
   