Console.WriteLine("Classificador de Faixa Etária");
Console.WriteLine("------------------------------------");

Console.WriteLine("Insira sua idade: ");
int idade = Int32.Parse(Console.ReadLine());

if(idade <= 12)
{
    Console.WriteLine("Você é Criança");
} else if (idade >=13 && idade <= 17)
{
    Console.WriteLine("Você é Adolescente");
} else if (idade >=18 && idade <= 59)
{
    Console.WriteLine("Você é Adulto");
} else if (idade >= 60)
{
    Console.WriteLine("Você é Idoso");
} else
{
    Console.WriteLine("Idade inválida ");
}