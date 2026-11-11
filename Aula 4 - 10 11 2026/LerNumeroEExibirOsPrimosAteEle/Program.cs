Console.WriteLine("Testador de Numero Primo");
Console.WriteLine("--------------------------------");

Console.WriteLine("Insira o numero a ser encontrados todos os primos até ele: ");
int numero = int.Parse(Console.ReadLine());
int contador = 0;

for (int i = numero; i >= 1; i--)
{
    if (numero % i == 0)
        contador++;

    if (contador > 2)
        Console.WriteLine("O numero informado não é primo");
        break;
}