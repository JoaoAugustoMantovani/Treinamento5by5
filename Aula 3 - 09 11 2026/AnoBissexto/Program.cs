Console.WriteLine("Cálculo de Ano Bissexto");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Insira um ano e será calculado se é ou não bissexto: ");
int? ano = Int32.Parse(Console.ReadLine());

if (ano < -45)
{
    Console.WriteLine("Ano bissexto só começa a existir apartir de 45 a.c. ");
    Environment.Exit(1);
}

if (ano % 4 == 0 && (ano%100 != 0 || ano%400 == 0))
{
    Console.WriteLine($"{ano} é ano bissexto");
}
else
{
    Console.WriteLine($"{ano} não é ano bissexto");
}
