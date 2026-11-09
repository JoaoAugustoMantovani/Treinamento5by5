Console.WriteLine("Comparação de Par ou Impar");
Console.WriteLine("--------------------------------");

Console.WriteLine("Insira um número que deseja saber se é Par ou Impar: ");
int? numero = int.Parse(Console.ReadLine());

if(numero%2 == 0)
{
    Console.WriteLine("o numero é Par");
} else if (numero%2 == 1)
{
    Console.WriteLine("O numero é impar");
}