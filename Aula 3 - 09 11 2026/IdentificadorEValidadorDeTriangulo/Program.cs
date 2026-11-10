Console.WriteLine("Identificador e Validador de Triangulos");
Console.WriteLine("---------------------------------------------");

Console.WriteLine("Insira o primeiro lado do triângulo");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo lado do triângulo");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("Insira o terceiro lado do triângulo");
float lado3 = float.Parse(Console.ReadLine());

if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
{
    if (lado1 > 0 && lado2 > 0 && lado3 > 0)
    {
        if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
        {
            Console.WriteLine("É um triângulo Escaleno!");
        }
        else if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1)
        {
            Console.WriteLine("É um triângulo Equilátero!");
        }
        else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
        {
            Console.WriteLine("É um triângulo Isósceles!");
        }
    }
    else
    {
        Console.WriteLine("Os lados não podem ser negativos");
    }
}
else
{
    Console.WriteLine("Não é um triângulo");
}