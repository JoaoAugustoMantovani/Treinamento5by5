int tamanholinha = 2, tamanhocoluna = 3;
int[,] matriz = new int[tamanholinha, tamanhocoluna];
int[,] matrizInvertida = new int[tamanholinha, tamanhocoluna];
int[,] matrizTransposta = new int[tamanhocoluna, tamanholinha];

PopularMatriz(matriz);
ImprimirMatriz(matriz, tamanholinha, tamanhocoluna);
GerarMatrizInvertida(matriz, matrizInvertida);
Console.WriteLine();
ImprimirMatriz(matrizInvertida, tamanholinha, tamanhocoluna);
Console.WriteLine();
GerarMatrizTransposta(matriz, matrizTransposta);
ImprimirMatriz(matrizTransposta, tamanhocoluna, tamanholinha);

void PopularMatriz(int[,] matriz)
{
    for (int linha = 0; linha < tamanholinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhocoluna; coluna++)
        {
            matriz[linha, coluna] = Random.Shared.Next(0, 99);
        }
    }
}
void GerarMatrizInvertida(int[,] matriz, int[,] matrizInvertida)
{
    int aux1 = tamanholinha - 1, aux2 = tamanhocoluna - 1;

    for (int linha = 0; linha < tamanholinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhocoluna; coluna++)
        {
            matrizInvertida[linha, coluna] = matriz[aux1, aux2];
            aux2--;
        }
        aux2 = tamanhocoluna - 1;
        aux1--;
    }

}
void ImprimirMatriz(int[,] matriz, int tamanholinha, int tamanhocoluna)
{
    for (int linha = 0; linha < tamanholinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhocoluna; coluna++)
        {
            Console.Write(matriz[linha, coluna] + "\t");
        }
        Console.WriteLine();
    }
}

void GerarMatrizTransposta(int[,] matriz, int[,] matrizTransposta)
{
    for (int linha = 0; linha < tamanholinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhocoluna; coluna++)
        {
            matrizTransposta[coluna,linha] = matriz[linha,coluna];
        }
    }
}