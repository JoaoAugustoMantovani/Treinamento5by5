Console.WriteLine("Informe o tamanho da Matriz: ");
int tamanho = int.Parse(Console.ReadLine());

int[,] matriz = new int[tamanho, tamanho];

PopularMatriz(matriz);
ExibirMatriz(matriz, tamanho, tamanho);
SomaLinha(matriz, tamanho, tamanho);
SomaColuna(matriz, tamanho, tamanho);
SomaDiagonalPrincipal(matriz, tamanho, tamanho);
SomaDiagonalSecundaria(matriz, tamanho, tamanho);
void PopularMatriz(int[,] matriz)
{
    for (int linha = 0; linha < tamanho; linha++)
    {
        for (int coluna = 0; coluna < tamanho; coluna++)
        {
            matriz[linha, coluna] = Random.Shared.Next(0, 9);
        }
    }
}

void ExibirMatriz(int[,] matriz, int tamanhoLinha, int tamanhoColuna)
{
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            Console.Write($"[{matriz[linha, coluna]}] ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SomaLinha(int[,] matriz, int tamanhoLinha, int tamanhoColuna)
{
    int soma = 0;
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            soma += matriz[linha, coluna];
        }
        Console.WriteLine($"Soma da linha {linha + 1} é: [{soma}]");
        soma = 0;
    }
}

void SomaColuna(int[,] matriz, int tamanhoLinha, int tamanhoColuna)
{
    int soma = 0;
    int coluna = 0;
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            soma += matriz[coluna, linha];
        }
        Console.WriteLine($"Soma da Coluna {coluna + 1} é: [{soma}]");
        soma = 0;
        coluna = 0;
    }
}

void SomaDiagonalPrincipal(int[,] matriz, int tamanhoLinha, int tamanhoColuna)
{
    int soma = 0;
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            if (linha == coluna)
            {
                soma += matriz[linha, coluna];
            }
        }
    }
    Console.WriteLine($"Soma da diagonal principal é: [{soma}]");
}

void SomaDiagonalSecundaria(int[,] matriz, int tamanhoLinha, int tamanhoColuna)
{
    int soma = 0;
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            if (linha + coluna == tamanho - 1)
            {
                soma += matriz[linha, coluna];
            }
        }
    }
    Console.WriteLine($"Soma da diagonal secundária é: [{soma}]");
}