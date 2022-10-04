/* Ejemplo de Condicional If*/

//Console.Write("Ingrese su edad: ");
//int edad =  int.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese su equipo de futbol: ");
//string equipo = Console.ReadLine();

//Console.WriteLine("la edad ingresada es: " + edad);

//if (edad < 18 && equipo == "River")
//{
//    Console.WriteLine("Usted es menor de edad.");
//    Console.WriteLine("Prohibida la entrada.");
//}
//else
//{
//    Console.WriteLine("Usted es mayor de edad.");
//}

//Console.Write("Ingrese la edad: ");
//int edad = int.Parse(Console.ReadLine());


//if (edad < 0 || edad > 100)
//{
//    Console.WriteLine("Ingrese una edad valida");
//}   
//else if (edad < 12)
//{
//    Console.WriteLine("Va a la primaria");
//}  else if (edad < 18)
//{
//    Console.WriteLine("Va al secundario");
//}
//else if (edad < 28)
//{
//    Console.WriteLine("Va a la facultad");
//} else
//{
//    Console.WriteLine("A trabajar no queda otra xD");
//}


// EJEMPLO DE SWITCH

//Console.WriteLine("Ingrese el primer numero: ");
//double num1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese el segundo numero: ");
//double num2 = double.Parse(Console.ReadLine());

//Console.WriteLine("1 - Suma");
//Console.WriteLine("2 - Resta");
//Console.WriteLine("3 - Multiplicación");
//Console.WriteLine("4 - División");

//Console.WriteLine("Ingrese la operación a realizar");
//string operacion = Console.ReadLine();

//double resultado;

//switch (operacion)
//{
//    case "1":
//      resultado = num1 + num2;
//        break;
//    case "2":
//      resultado = num1 - num2;
//        break;
//    case "3":
//     resultado = num1 * num2;
//        break;
//    case "4" when num2 != 0:
//      resultado = num1 / num2;
//        break;
//    default:
//        Console.WriteLine("Ingreso una opcion no valida");
//        break;
//}

//Console.WriteLine("El resultado es: " + resultado);
//// lo que continue





/*  EJEMPLO If-Else anidados */


//int numero1, numero2, numero3; //Declaramos las variables

//Console.Write("Ingrese numero 1: ");
//numero1 = int.Parse(Console.ReadLine()); //ingresamos el primer numero

//Console.Write("Ingrese numero 2: ");
//numero2 = int.Parse(Console.ReadLine()); //Ingresamos el segundo numero

//Console.Write("Ingrese numero 3: ");
//numero3 = int.Parse(Console.ReadLine()); //Ingresamos el tercer numero

//if (numero1 > numero2) //numero1 es mayor
//{
//    //Instrucciones
//    if (numero1 > numero3) //numero1 es mayor
//    {
//        //Instrucciones
//        Console.WriteLine("El primer numero es el mayor: " + numero1);
//    }
//    else //numero3 es mayor
//    {
//        //Instrucciones
//        Console.WriteLine("El tercer numero es el mayor: " + numero3);
//    }
//}
//else //numero2 es mayor
//{
//    //Instrucciones
//    if (numero2 > numero3) //numero2 es mayor
//    {
//        //Instrucciones
//        Console.WriteLine("El segundo numero es el mayor: " + numero2);
//    }
//    else
//    {
//        //Instrucciones
//        Console.WriteLine("El tercer numero es el mayor: " + numero3);
//    }
//}


//Lo que continue.....

Console.WriteLine("Desea continuar? (S/N)");
var texto = Console.ReadLine();

if (texto.ToUpper()=="S")
{
    Console.WriteLine("Usted ingreso que SI");
}
else if (texto.ToLower()=="n") 
{
    Console.WriteLine("Usted Ingreso que NO");
} else
{
    Console.WriteLine("Usted no entendio nada");
}