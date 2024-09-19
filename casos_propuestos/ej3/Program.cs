int n;
double x, denominador = 1, numerador = 0, acumulador = 0;

Console.Write("Ingrese un numero: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese la cantidad de terminos de la serie: ");
n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    numerador = (Math.Pow(x, i));
    if (i > 1)
    {
        denominador *= i;
    }
    acumulador += numerador / denominador;
    Console.WriteLine(acumulador);
}
