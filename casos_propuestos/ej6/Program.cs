int n, acumulador = 0;

Console.Write("Ingrese un numero: ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Numeros perfectos: ");
for (int i = 2; i <= n; i++)
{
    for (int p = 1; p < i; p++)
    {
        if (i % p == 0)
        {   
            acumulador += p;
        }

    }

    if (acumulador == i)
    {
        Console.WriteLine(i);
    }
    acumulador = 0; 
}