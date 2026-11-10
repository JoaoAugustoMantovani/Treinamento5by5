Console.WriteLine("Exibidor de Tabuada até o 10");
Console.WriteLine("-------------------------------------");

Console.WriteLine("Insira o numero que deseja ver a Tabuada até o 10: ");
int numero = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} * {numero} = " + (i * numero));
}