Console.Write("Ingrese un numero: ");
int number = Convert.ToInt32(Console.ReadLine());
int contador = 1;
int acumulador = 1;

while (contador <= number)
{
    acumulador *= contador;
    contador++;
}
Console.WriteLine(acumulador);
