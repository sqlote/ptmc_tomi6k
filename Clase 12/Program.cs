using Clase_12;

//var inicio = DateTime.Now;

//var fin = DateTime.Now;

//var demora = fin - inicio;

var alumno1 = new Alumno();

alumno1.Apellido = "Mateos";
alumno1.Nombre = "Joaquin";
alumno1.Legajo = 1;
alumno1.Dni = "30.200.300";
alumno1.FechaNacimiento =  new DateTime(1986,11,04);

var alumno2 = new Alumno()
{
    Apellido = "Etchecoin",
    Nombre = "Ezequiel",
    Legajo = 2,
    Dni = "42.560.220",
    FechaNacimiento = new DateTime(2000, 6, 2),
};


alumno1.GetInfo();
alumno2.GetInfo();