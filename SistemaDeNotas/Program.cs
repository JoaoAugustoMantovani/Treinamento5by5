Console.WriteLine("Sistema de Notas");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("O Sistema recebe 4 notas, calcula uma média e informa o status do aluno");
Console.WriteLine("Média maior ou igual a 7 = Aprovado");
Console.WriteLine("Média entre 5,1 e 6,9 = Recuperação");
Console.WriteLine("Média menor ou igual a 5 = reprovado");
Console.WriteLine("--------------------------------------------");

float nota1 = 0.00f;
float nota2 = 0.00f;
float nota3 = 0.00f;
float nota4 = 0.00f;

Console.WriteLine("Insira a primeira nota (Se for decimal, com vírugla): ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a segunda nota (Se for decimal, com vírugla): ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a terceira nota (Se for decimal, com vírugla): ");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a quarta nota (Se for decimal, com vírugla): ");
nota4 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4) / 4;

if(nota1 > 10 || nota2 > 10 || nota3 > 10 || nota4 > 10)
{
    Console.WriteLine("A nota não pode ser maior que 10");
    Environment.Exit(0);
}

if (media <= 5)
{
    Console.WriteLine("Você está reprovado");
    Console.WriteLine($"Sua média é {media}");
} else if (media >= 7)
{
    Console.WriteLine("Você está aprovado");
    Console.WriteLine($"Sua média é {media}");
} else
{
    Console.WriteLine("Você está de recuperação");
    Console.WriteLine($"Sua média é {media}");
}
