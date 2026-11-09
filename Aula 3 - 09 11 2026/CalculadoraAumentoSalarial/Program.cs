Console.WriteLine("Calculadora Aumento Salarial");
Console.WriteLine("----------------------------------------");

Console.WriteLine("Insira seu salário: ");
float salario = float.Parse(Console.ReadLine());

float novoSalario = 0.00f;

if (salario < 2000.00)
{
    novoSalario = salario * 1.15f;

    Console.WriteLine("Seu salário recebeu um aumento de 15%");
    Console.WriteLine($"Novo salário: {novoSalario}");
} else if (salario >= 2000.01 && salario <= 4000.00)
{
    novoSalario = salario * 1.1f;

    Console.WriteLine("Seu salário recebeu um aumento de 10%");
    Console.WriteLine($"Novo salário: {novoSalario}");
} else if (salario > 4000)
{
    novoSalario = salario * 1.05f;

    Console.WriteLine("Seu salário recebeu um aumento de 5%");
    Console.WriteLine($"Novo salário: {novoSalario}");
}
