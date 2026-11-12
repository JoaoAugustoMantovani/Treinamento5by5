using System.Security.Cryptography;



Console.WriteLine("Informe o tamanho da linha da Matriz: ");
int tamanhoLinha = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o tamanho das colunas");
int tamanhoColuna = int.Parse(Console.ReadLine());
int[,] matriz = new int[tamanhoLinha, tamanhoColuna];

PopularMatriz(matriz);
ExibirMatriz(matriz);
ExibirMatrizInvertida(matriz);


void PopularMatriz(int[,] matriz)
{
    for (int i = 0; i < tamanhoLinha; i++)
    {
        for (int j = 0; j < tamanhoColuna; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 4);
        }
    }
}

void ExibirMatriz(int[,] matriz)
{

    Console.WriteLine("Exibindo Matriz Normal");
    for (int i = 0; i < tamanhoLinha; i++)
    {
        for(int j = 0; j < tamanhoColuna; j++)
        {
            Console.WriteLine($"[{i},{j}]");
        }
    }
}

void ExibirMatrizInvertida(int[,] matriz)
{
    Console.WriteLine("Exibindo Matriz Invertida");
    for (int i = tamanhoLinha - 1; i >= 0; i--)
    {
        for (int j = tamanhoColuna - 1; j >= 0; j--)
        {
            Console.WriteLine($"[{i},{j}]");
        }
    }
}

