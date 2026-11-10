Console.WriteLine("Numero Par e Impar Ordenado");
Console.WriteLine("-------------------------------");

Console.WriteLine("Insira o Numero que deseja ver ordenado entre par e impar");
int numero = Int32.Parse(Console.ReadLine());

Console.WriteLine("Numero Impares Ordenados em ordem crescente");
for(int i = 0; i <= numero; i++)
{
    if (i%2 == 1)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("Numeros Pares Ordenados em ordem decrescente");
for (int i = numero; i >=0 ; i--)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}
