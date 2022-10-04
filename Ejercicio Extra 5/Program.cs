//  Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)
Console.Clear();

Console.WriteLine("Ingrese el precio del producto: ");
int precio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El precio del producto es: $" + precio + ". ¿Desea pagar con Efectivo o Tarjeta?");
string pago = Convert.ToString(Console.ReadLine());
string tipo = "Tarjeta";
bool pagoV = pago.Equals(tipo);

if(pagoV)
{
    Console.WriteLine("Ingrese el numero de tarjeta");
    string tarjeta = Console.ReadLine();
    Console.WriteLine("Se ha cobrado $" + precio + " en la tarjeta Nro. " + tarjeta);
} else
{
    Console.WriteLine("Su pago es en efectivo.");
}
Console.ReadKey();