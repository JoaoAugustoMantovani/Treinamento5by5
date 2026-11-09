Console.WriteLine("Comparação de Decimais se são maiores ou menores");
Console.WriteLine("---------------------------------------------------");

float numero1 = 0.0f;
float numero2 = 0.0f;

Console.WriteLine("Insira o primeiro numero decimal (Utilizando a vírgula) a ser comparado: ");
numero1  = float.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo numero decimal (Utilizando a vírgula) a ser comparado: ");
numero2 = float.Parse(Console.ReadLine());

if(numero1 == numero2)
{
    Console.WriteLine("Eles são iguais.");
}else if(numero1 > numero2)
{
    Console.WriteLine($"O numero {numero1} é maior que o numero {numero2}");
}
else
{
    Console.WriteLine($"O numero {numero2} é maior que o numero {numero1}");
}