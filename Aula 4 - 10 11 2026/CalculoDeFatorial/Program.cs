Console.WriteLine("Calculo de Fatorial");
Console.WriteLine("---------------------------");

Console.WriteLine("Insira o numero que será feita a fatorial: ");
int numero = Int32.Parse(Console.ReadLine());

long fatorial = 1;

for (int i = 1; i<= numero; i++)
{
    fatorial *= i;
    Console.WriteLine(fatorial);
}