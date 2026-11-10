Console.WriteLine("Testador de Numero Primo");
Console.WriteLine("--------------------------------");

Console.WriteLine("Insira o numero a ser encontrados todos os primos até ele: ");
int numero = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if (i <= 1)
    {
        Console.WriteLine(1);
    }
    else if (i <= 2)
    {

        Console.WriteLine(2);
    }
    else if (i <= 3)
    {
        Console.WriteLine(3);
        i++;
    }
    else if (i <= 5)
    {
        Console.WriteLine(5);
        i++;
    }
    else if (i <= 7)
    {
        Console.WriteLine(7);
    }
    else if (i % i == 0 && i % 1 == 0 && i % 2 != 0 && i % 3 != 0 && i % 4 != 0 && i % 5 != 0 && i % 6 != 0 && i % 7 != 0 && i % 8 != 0 && i % 9 != 0)
    {
        Console.WriteLine(i);
    }

}