Console.Clear();

// Pedimos el nombre de una persona y una ciudad

Console.WriteLine("Ingrese un nombre de Persona: ");
string nombre;
nombre = Console.ReadLine();

Console.WriteLine("Ingrese un nombre de Ciudad: ");
string ciudad;
ciudad = Console.ReadLine();

// Mostramos ambos

Console.WriteLine("Bienvenido " + nombre + " a " + ciudad);

Console.ReadKey();