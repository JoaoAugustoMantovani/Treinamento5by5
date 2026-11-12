using System.Security.Cryptography;

int[,] matriz = new int[3, 5];
int[,] matrizInvertida = new int [5, 3];

PopularMatriz(matriz);
GerarMatrizInvertida(matriz, matrizInvertida);


void GerarMatrizInvertida(int[,] matriz, int[,] matrizInvertida)
{
    for(int i = 5; i >= 0; i--)
    {
        for(int j = 3; j >= 0; j--)
        {
            matrizInvertida[i, j] = matriz[j, i];
        }
    }

    for (int i = 5; i >= 0; i--)
    {
        for (int j = 3; j >= 0; j--)
        {
            Console.WriteLine($"[{i}] , [{j}]");
        }
    }

}

void PopularMatriz(int[,] matriz)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(0, 99);
        }
    }

    for (int i = 3; i <= 0; i--)
    {
        for (int j = 3; j <= 0; j--)
        {
            Console.WriteLine($"[{i}] , [{j}]");
        }
    }
}