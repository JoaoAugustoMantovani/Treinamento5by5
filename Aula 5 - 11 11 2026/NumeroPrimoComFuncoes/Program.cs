//void Hello (string nome)
//{
//    Console.WriteLine(("Hello, " + nome + "!"));
//}

//string nome;
//Console.WriteLine("Informe seu nome: ");
//Hello(Console.ReadLine());

Console.WriteLine("Informe o numero desejado: ");
int Numero = int.Parse(Console.ReadLine());

for(int i = 2;  i <= Numero; i++)
{
    if (EPrimo(Numero))
    {
        Console.WriteLine(i);
    }
}

bool EPrimo(int numero)
{
    if (numero <= 1)
        return false;

    int contador = 0;

    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            contador++;
        }
    }
    if (contador > 2)
    {
        return false;
    }
    else
    {
        return true;
    }
}

