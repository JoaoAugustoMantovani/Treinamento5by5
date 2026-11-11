Console.WriteLine("Ler até 6 Chars e exibir ele na ordem inserida e invertida");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Instruções: Digite apenas o caracter desejado na proxima pergunta, se não quiser inserir nenhum e terminar o vetor, insira um vazio");
Console.WriteLine("Pressione qualquer tecla para continuar... ");
Console.ReadKey();
Console.Clear();

char[] charVector = new char[6];

AdicionaTeclas();
MostrarVetor();
 

void AdicionaTeclas()
{
    int contador = 0;
    while (contador < 6)
    {
        Console.WriteLine("Insira até 6 caracteres (Aperte Enter para encerrar antes): ");
        char tecla = Console.ReadKey(false).KeyChar;
        Console.WriteLine("\n");
        //Verificando se apertou Enter
        if (tecla == '\r')
        {
            Console.WriteLine("Enter pressionado\n");
            break;
        }
        
        charVector[contador] = tecla;

        //Somando 1 ao contador
        contador++;
    }
}

void MostrarVetor()
{
    Console.WriteLine("\nOrdem de inserção: \n");
    int contador = 0;
    while (contador < 6)
    {
        if (charVector[contador] == '\0')
        {

        }
        else
        {
        Console.Write($"{contador}: {charVector[contador]};\n");
        }
        contador++;
    }

    Console.WriteLine("\nOrdem contrária de inserção: \n");
    contador = 5;
    
    while (contador >= 0)
    {
        if (charVector[contador] == '\0')
        {

        }
        else
        {
            Console.Write($"{contador}: {charVector[contador]};\n");
        }
        contador--;
    }

}


