Console.Clear();

// Ingreso de numeros

Console.WriteLine("Ingrese un numero.");
int numeroUno;
numeroUno = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese otro numero.");
int numeroDos;
numeroDos = Convert.ToInt32(Console.ReadLine());

bool numeroMayor = numeroUno >= numeroDos;

if (numeroMayor)
    {
    Console.WriteLine("El primer numero es mayor o igual al segundo");
}
else
{
    Console.WriteLine("El segundo numero es mayor que el primero");
}

Console.ReadKey();