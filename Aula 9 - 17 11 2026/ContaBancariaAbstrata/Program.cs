ExecutarAplicativo();

void ExecutarAplicativo()
{
    ContaBancaria[] contas = CadastrarContas();
    MostrarMenuDeMovimentacao(contas);
}

ContaBancaria[] CadastrarContas()
{
    ContaBancaria[] contas = new ContaBancaria[0];
    bool criarOutra = true;

    for (int numero = 1; criarOutra; numero++)
    {
        ContaBancaria novaConta = CriarConta(numero);
        contas = AdicionarConta(contas, novaConta);

        Console.WriteLine($"Conta {novaConta.Numero} cadastrada com sucesso!");
        criarOutra = PerguntarSeCriaOutra();
    }

    return contas;
}

ContaBancaria CriarConta(int numero)
{
    char tipo = '\0';
    double saldoInicial = 0;

    for (int tentativa = 1; tipo < '1' || tipo > '3'; tentativa++)
    {
        Console.WriteLine("\n========== MANTOBANK ==========");
        Console.WriteLine("Que tipo de conta deseja criar?");
        Console.WriteLine("1 - Conta Poupança");
        Console.WriteLine("2 - Conta Corrente");
        Console.WriteLine("3 - Conta Salário");
        Console.Write("Opção: ");

        char.TryParse(Console.ReadLine(), out tipo);

        if (tipo < '1' || tipo > '3')
            Console.WriteLine("Tipo de conta inválido.");
    }

    switch (tipo)
    {
        case '1':
            return new ContaPoupanca(numero, saldoInicial);
        case '2':
            return new ContaCorrente(numero, saldoInicial);
        case '3':
            return new ContaSalario(numero, saldoInicial);
        default:
            throw new ArgumentException("Tipo de conta inválido.");
    }
}

ContaBancaria[] AdicionarConta(ContaBancaria[] contas, ContaBancaria novaConta)
{
    ContaBancaria[] novoVetor = new ContaBancaria[contas.Length + 1];

    for (int i = 0; i < contas.Length; i++)
    {
        novoVetor[i] = contas[i];
    }

    novoVetor[contas.Length] = novaConta;
    return novoVetor;
}

bool PerguntarSeCriaOutra()
{
    char resposta = '\0';

    for (int tentativa = 1; resposta != 'S' && resposta != 'N'; tentativa++)
    {
        Console.Write("Deseja criar outra conta? (S/N): ");
        char.TryParse(Console.ReadLine()?.ToUpper(), out resposta);

        if (resposta != 'S' && resposta != 'N')
            Console.WriteLine("Opção inválida.");
    }

    return resposta == 'S';
}

void MostrarMenuDeMovimentacao(ContaBancaria[] contas)
{
    bool menuAberto = true;

    for (int rodada = 1; menuAberto; rodada++)
    {
        ListarContas(contas);

        Console.Write("Digite o número da conta ou 0 para sair: ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Número inválido.");
            continue;
        }

        if (numero == 0)
        {
            menuAberto = false;
            continue;
        }

        int indice = BuscarIndiceDaConta(contas, numero);

        if (indice == -1)
        {
            Console.WriteLine("Conta não encontrada.");
            continue;
        }

        MovimentarConta(contas, contas[indice]);
    }
}

void ListarContas(ContaBancaria[] contas)
{
    Console.WriteLine("\n========== CONTAS CADASTRADAS ==========");

    for (int i = 0; i < contas.Length; i++)
    {
        Console.WriteLine($"{contas[i].Numero} - {contas[i].GetType().Name}");
    }
}

int BuscarIndiceDaConta(ContaBancaria[] contas, int numero)
{
    for (int i = 0; i < contas.Length; i++)
    {
        if (contas[i].Numero == numero)
            return i;
    }

    return -1;
}

void MovimentarConta(ContaBancaria[] contas, ContaBancaria conta)
{
    Console.WriteLine($"\n========== CONTA {conta.Numero} ==========");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Transferir");
    Console.WriteLine("4 - Pagar");
    Console.WriteLine("5 - Consultar saldo");
    Console.WriteLine("0 - Voltar");
    Console.Write("Opção: ");

    if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 || opcao > 5)
    {
        Console.WriteLine("Opção inválida.");
        return;
    }

    if (opcao == 0)
        return;

    if (opcao == 5)
    {
        Console.WriteLine($"Saldo atual: {conta.Saldo:C2}");
        return;
    }

    Console.Write("Valor: ");
    if (!double.TryParse(Console.ReadLine(), out double valor)
        || !double.IsFinite(valor) || valor <= 0)
    {
        Console.WriteLine("Digite um valor válido e maior que zero.");
        return;
    }

    switch (opcao)
    {
        case 1:
            MostrarResultado(conta.Depositar(valor));
            break;
        case 2:
            MostrarResultado(conta.Sacar(valor));
            break;
        case 3:
            FazerTransferencia(contas, conta, valor);
            break;
        case 4:
            MostrarResultado(conta.Pagar(valor));
            break;
    }
}

void FazerTransferencia(ContaBancaria[] contas, ContaBancaria origem, double valor)
{
    Console.Write("Número da conta de destino: ");
    if (!int.TryParse(Console.ReadLine(), out int numeroDestino))
    {
        Console.WriteLine("Número inválido.");
        return;
    }

    int indiceDestino = BuscarIndiceDaConta(contas, numeroDestino);

    if (indiceDestino == -1)
    {
        Console.WriteLine("Conta de destino não encontrada.");
        return;
    }

    ContaBancaria destino = contas[indiceDestino];

    if (destino.Numero == origem.Numero)
    {
        Console.WriteLine("Escolha uma conta diferente da conta de origem.");
        return;
    }

    MostrarResultado(origem.Transferir(origem, destino, valor));
}

void MostrarResultado(bool sucesso)
{
    Console.WriteLine(sucesso ? "Operação concluída." : "Operação recusada.");
}