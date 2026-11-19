FilaNormal filaNormal = new FilaNormal();
FilaPreferencial filaPreferencial = new FilaPreferencial();
int preferenciaisSeguidas = 0;

while (true)
{
    Console.WriteLine("\nHospital Só Falta Você");
    Console.WriteLine("1 - Gerar senha normal");
    Console.WriteLine("2 - Gerar senha preferencial");
    Console.WriteLine("3 - Chamar próxima senha");
    Console.WriteLine("0 - Sair");

    string? opcao = Console.ReadLine();

    if (opcao == "0" || opcao == null)
    {
        break;
    }

    if (opcao == "1" || opcao == "2")
    {
        Fila novoNo = new Fila();
        int numero = Random.Shared.Next(1, 200);

        if (opcao == "2")
        {
            novoNo.Senha = $"P{numero}";
            filaPreferencial.InserirElemento(novoNo);
        }
        else
        {
            novoNo.Senha = $"N{numero}";
            filaNormal.InserirElemento(novoNo);
        }

        Console.WriteLine($"Sua senha é {novoNo.Senha}");
    }
    else if (opcao == "3")
    {
        if (!filaNormal.FilaVazia() &&
            (preferenciaisSeguidas == 2 || filaPreferencial.FilaVazia()))
        {
            string senha = filaNormal.Head.Senha;
            filaNormal.RemoverElemento();
            preferenciaisSeguidas = 0;
            Console.WriteLine($"Chamando {senha}");
        }
        else if (!filaPreferencial.FilaVazia())
        {
            string senha = filaPreferencial.Head.Senha;
            filaPreferencial.RemoverElemento()

            if (preferenciaisSeguidas < 2)
            {
                preferenciaisSeguidas++;
            }

            Console.WriteLine($"Chamando {senha}");
        }
        else
        {
            Console.WriteLine("Não há ninguém na fila.");
        }
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}