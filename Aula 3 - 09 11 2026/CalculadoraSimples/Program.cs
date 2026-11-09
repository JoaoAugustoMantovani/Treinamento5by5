Console.WriteLine("Calculadora Simples");
Console.WriteLine("---------------------------------------");
Console.WriteLine("Operações disponíveis:");
Console.WriteLine("(1) - Soma");
Console.WriteLine("(2) - Subtração");
Console.WriteLine("(3) - Multiplicação");
Console.WriteLine("(4) - Divisão");
Console.WriteLine("Selecione o número de qual deseja realizar");
int opcao = Int16.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:

        Console.WriteLine("Digite o primeiro número a ser somado: ");
        int soma1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número a ser somado: ");
        int soma2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"O Resultado da soma de {soma1} + {soma2} é = {soma1 + soma2}");
        break;

    case 2:

        Console.WriteLine("Digite o primeiro número a ser subtraido: ");
        int subtracao1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número a ser subtraido: ");
        int subtracao2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"O Resultado da subtração de {subtracao1} - {subtracao2} é = {subtracao1 - subtracao2}");

        break;

    case 3:
        Console.WriteLine("Digite o primeiro número a ser multiplicado: ");
        int multiplicacao1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número a ser multiplicado: ");
        int multiplicacao2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"O Resultado da multiplicação de {multiplicacao1} * {multiplicacao2} é = {multiplicacao1 * multiplicacao2}");
        break;

    case 4:
        Console.WriteLine("Digite o primeiro número a ser dividido: ");
        int divisao1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número a ser dividido: ");
        int divisao2 = Int32.Parse(Console.ReadLine());

        if (divisao1 == 0 || divisao2 == 0)
        {
            Console.WriteLine("Não é possível dividir por 0");
            Environment.Exit(0);
        }

        Console.WriteLine($"O Resultado da divisão de {divisao1} / {divisao2} é = {divisao1 / divisao2}");
        break;

}






