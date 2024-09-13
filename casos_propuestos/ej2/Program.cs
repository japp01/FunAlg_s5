Console.Write("Ingrese un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());
int length = numero.ToString().Length;
double par = 0, impar = 0, valor;
byte acumulador = 1;
int lengthReplica = length;

while (length > 0)
{
    valor = numero % 10;

    if (acumulador % 2 != 0)
    {
        impar += valor;
    }
    else
    {
        par += valor;
    }

    numero /= 10;
    length--;
    acumulador++;
}

Console.WriteLine($"Cantidad de digitos: {lengthReplica}");
Console.WriteLine($"Suma de digitos impares: {impar}");
Console.WriteLine($"Suma de digitos pares: {par}");