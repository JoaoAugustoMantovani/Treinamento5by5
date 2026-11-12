int tamanho = 10;
char[] vetor1 = new char[tamanho];
string[] vetor2 = new string[tamanho * 2];

void PopularVetor(char[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine("Informe a leta desejada: ");
        vetor[i] = char.Parse(Console.ReadLine()!);
    }
}

int ConverterASCII(char letra)
{
    return (int)letra;
}

void CriarVetorASCII()
{
    for (int i = 0; i < vetor2.Length; i++)
    {
        vetor2[i] = vetor1[i].ToString();
        vetor2[i + 1] = ConverterASCII(vetor1[i]).ToString();
    }
}
void ExibirVetor(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"[{vetor[i]}] ");
    }
    Console.Write("\n");
}

string[] temp = new string[vetor1.Length];
for (int i = 0; i < vetor1.Length; i++)
{
    temp[i] = vetor1[i].ToString();
}

PopularVetor(vetor1);
ExibirVetor(temp);
CriarVetorASCII();
ExibirVetor(vetor2);
