Console.WriteLine("Vetor de string de 10 posições que copie para outro e adicionando o valor da tabela ascii");
Console.WriteLine("---------------------------------------------");

string[] vetor = new string[10];
string[] vetor2 = new string[20];

ConstrutorDeVetor();
ConversorDeVetorParaASCII();
void ConstrutorDeVetor()
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine("Insira o caractere a ser convertido para ASCII: ");
        vetor[i] = Console.ReadLine();
    }
}

void ConversorDeVetorParaASCII()
{
    for (int i = 0; i < vetor.Length; i++)
    {
        vetor2[i] = vetor[i];
        Console.Write($"[{vetor2[i]}]");
        vetor2[i + 1] = ((int)vetor[i][0]).ToString();
        Console.WriteLine($"[{vetor2[i+1]}]");

    }
}