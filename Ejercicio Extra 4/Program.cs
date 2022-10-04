Console.Clear();

// Ingresamos un dia de la semana

Console.WriteLine("Ingrese un dia de la semana: ");
string dia = Console.ReadLine();

// Se define que dia es fin de semana
string findeUno = "Sabado";
string findeDos = "Domingo";

// variables para comparacion
bool findeS = dia.Equals(findeUno);
bool findeD = dia.Equals(findeDos);

// comparacion de datos
    if (findeS)
{
    Console.WriteLine("Este dia es un fin de semana.");
} else
{
    if (findeD)
    {
        Console.WriteLine("Este dia es un fin de semana.");
    } else
    {
        Console.WriteLine("Este dia NO es un fin de semana. :(");
    }
}

Console.ReadKey();
