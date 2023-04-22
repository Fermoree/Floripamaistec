List<int> numerosUser = new List<int> { };
List<int> numerosPrimos = new List<int> { };

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite o {i}º número: ");
    int numero = int.Parse(Console.ReadLine());
    numerosUser.Add(numero);

    List<int> divisores = new List<int> { };
    for (int y = 1; y <= numero; y++)
    {
        if (numero % y == 0)
        {
            divisores.Add(y);
        }
    }

    if (divisores.Count() <= 2)
    {
        numerosPrimos.Add(numero);
    }
}

if (numerosPrimos.Count() == 0)
{
    Console.WriteLine("Nenhum número informado pelo o Usuário é primo!");
}

else if (numerosPrimos.Count() == 1)
{
    Console.Write("O único número primo informado pelo Usuário é ");
    foreach (var n in numerosPrimos)
    {
        int index = numerosUser.IndexOf(n);
        Console.WriteLine($"{n} e a sua posição é {index}.");
    }
}

else
{
    Console.Write("Os números primos são: ");
    foreach (var n in numerosPrimos)
    {
        int index = numerosUser.IndexOf(n);
        if (n != numerosPrimos.Last())
        {
            Console.Write($"{n} (posição {index}); ");
        }
        else
        {
            Console.WriteLine($"{n} (posição {index}).");
        }
    }
}


