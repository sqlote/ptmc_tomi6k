Clase de Ciclos while y for

Console.WriteLine("Cuantas vueltas quiere dar?");

var totalDeVueltas = int.Parse(Console.ReadLine());

var contador = 0;
string respuesta = "S";

while (respuesta.ToUpper() != "N")  // <= da 1 mas que la cantidad asignada de vueltas
{
    contador++; // contador = contador + 1;
    Console.WriteLine("Seguimos dando vueltas, vuelta N°: " + contador);

    Console.WriteLine("Seguimos? (S/N)");
    respuesta = Console.ReadLine();
}

Console.WriteLine("Dimos " + contador + " vueltas.");





