Console.WriteLine("Gerador de Fibonacci");
Console.WriteLine("-----------------------------");

Console.WriteLine("Insira a posição da sequencia de Fibonacci desejada");
int posicao = Int32.Parse(Console.ReadLine());

long fibonacci;
long n1 = 0;
long n2 = 1;

for(int i = 2; i <= posicao; i++)
{
    fibonacci = n1 + n2;
    n1 = n2;
    n2 = fibonacci;

    Console.WriteLine(fibonacci);
}
