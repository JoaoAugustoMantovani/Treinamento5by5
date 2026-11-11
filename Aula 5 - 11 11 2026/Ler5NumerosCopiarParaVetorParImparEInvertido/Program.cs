using System.Numerics;

Console.WriteLine(
    "Ler 5 Numeros, Salvar em um vetor, Copiar para outro com sequencia inversa\n" +
    "Copiar para vetor com os numeros pares e também para numeros impares");
Console.WriteLine("-------------------------------------------------");

int[] numeros = new int[5];
int[] invertidos = new int[5];
int[] pares = new int[5];
int[] impares = new int[5];

Run();

void Run()
{
    ConstruirVetor();
    ExibirVetorEmOrdem();
    ExibirVetorInvertido();
    ExibirApenasPares();
    ExibirApenasImpares();
}
void ConstruirVetor()
{
    int contador = 0;
    while (contador < 5)
    {
        Console.WriteLine("Insira um numero: ");
        numeros[contador] = int.Parse(Console.ReadLine());
        contador++;
    }
}

void ExibirVetorEmOrdem()
{
    Console.WriteLine("\nExibindo em ordem: ");
    int contador = 0;
    while (contador < 5)
    {
        Console.Write($"[{numeros[contador]}] ");
        contador++;
    }
}

void ExibirVetorInvertido()
{
    Console.WriteLine("\n\nExibindo invertido: ");
    int contador = 0;
    while (contador < 5)
    {
        int destino = 4 - contador;
        invertidos[contador] = numeros[destino];
        Console.Write($"[{invertidos[contador]}] ");
        contador++;
    }
}

void ExibirApenasPares()
{
    Console.WriteLine("\n\nExibindo apenas os pares: ");
    int contador = 0;
    while (contador < 5)
    {
        if (numeros[contador] %2 == 0)
        {
            pares[contador] = numeros[contador];
            Console.Write($"[{pares[contador]}] ");
        }
        contador++;
    }
}

void ExibirApenasImpares()
{
    Console.WriteLine("\n\nExibindo apenas os impares: ");
    int contador = 0;
    while (contador < 5)
    {
        if (numeros[contador] % 2 != 0)
        {
            impares[contador] = numeros[contador];
            Console.Write($"[{impares[contador]}] ");
        }
        contador++;
    }
}