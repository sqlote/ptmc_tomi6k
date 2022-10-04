Console.Clear();

Console.Write("Ingrese un número :");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese otro número :");
int num2 = Convert.ToInt32(Console.ReadLine());

bool cond = num1 > 1000;

if (cond)
{
   int operacion = num1 + num2;
    Console.WriteLine("El resultado es: " + operacion);
} else
{
    int operacion = num1 * num2;
    Console.WriteLine("El resultado es: " + operacion);
}


