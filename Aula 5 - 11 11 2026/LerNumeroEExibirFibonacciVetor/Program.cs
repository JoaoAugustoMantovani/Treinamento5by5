Console.WriteLine("Receber posição e determinar a sequencia fibonnaci com vetores");
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine("Insira a quantidade de posições que o Vetor terá: ");
int qtdPosicoes = int.Parse(Console.ReadLine());

long[] fibonacci = new long[qtdPosicoes];

CalcularFibonacci();
ExibirFibonacci();

void ExibirFibonacci()
{
    if (fibonacci.Length == 1)
    {
        fibonacci[0] = 0;
        Console.WriteLine(fibonacci[0]);
    }
    else if (fibonacci.Length == 2)
    {
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        Console.WriteLine(fibonacci[0]);
        Console.WriteLine(fibonacci[1]);
    }
    else
    {
        for (int i = 0; i < fibonacci.Length; i++)
        {
            Console.WriteLine(fibonacci[i]);
        }
    }
}

void CalcularFibonacci()
{
    long n1 = 0;
    long n2 = 1;
    fibonacci[0] = n1;
    fibonacci[1] = n2;
    for (int i = 2; i < qtdPosicoes; i++)
    {
        long fibo = n1 + n2;
        n1 = n2;
        n2 = fibo;

        fibonacci[i] = fibo;
    }
}