using Clase_13.Modelo;

Console.Clear();

var persona1 = new persona()
{
    NombreCompleto = "Tomas Canavidez",
    NumeroDocumento = "43429142",
    Edad = 21,
    EstaCasado = false
};

persona1.ObtenerSaludo();
persona1.ObtenerSaludo("Carlos");

// Esta clase tambien se incorpora desde el namespace Constructores.Modelo
var miOcupacion = new Ocupacion();


