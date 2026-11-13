using System.Runtime.Serialization;

string[,] boletim = new string[3,7];

//Matérias
boletim[0, 0] = "Matemática";
boletim[1, 0] = "Português";
boletim[2, 0] = "Ciências";

GerarNotas(boletim);
GerarMedia(boletim);
DefinirSituacoes(boletim);
ExibirBoletim(boletim);

void GerarNotas(string[,] boletim)
{
    for (int linha = 0; linha < 3; linha++)
    {
        for (int coluna = 1; coluna < 5; coluna++)
        {
            boletim[linha, coluna] = (Random.Shared.Next(0, 10)).ToString();
            
        }
    }
}

void GerarMedia(string[,] boletim)
{
    for (int linha = 0; linha < 3; linha++)
    {
        double soma = 0;
        for (int coluna = 1; coluna < 5; coluna++)
        {
            soma += double.Parse(boletim[linha, coluna]);
        }
        double media = soma / 4;
        boletim[linha, 5] = media.ToString();
    }
}

void DefinirSituacoes(string[,] boletim)
{
    for (int linha = 0; linha < 3; linha++)
    {
        double media = double.Parse(boletim[linha, 5]);

        if (media >= 7)
        {
            boletim[linha, 6] = "Aprovado";
        }
        else if (media > 5 && media < 7)
        {
            boletim[linha, 6] = "Recuperação";
        }
        else
        {
            boletim[linha, 6] = "Reprovado";
        }
    }
}

void ExibirBoletim(string[,] boletim)
{
    for (int linha = 0; linha < 3; linha++)
    {
        for (int coluna = 0; coluna < 7; coluna++)
        {
            Console.Write($"[{boletim[linha,coluna]}] ");
        }
        Console.WriteLine();
    }
}