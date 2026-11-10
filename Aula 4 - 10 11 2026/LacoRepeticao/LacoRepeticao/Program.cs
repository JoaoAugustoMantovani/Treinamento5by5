int contador = 10;

while (contador > 0)
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(1000);
}
Console.WriteLine("Happy new year!");

contador = 10;

do
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(1000);
} while (contador > 0);
Console.WriteLine("Happy new year!");

for(int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
}
Console.WriteLine("Happy new year!");