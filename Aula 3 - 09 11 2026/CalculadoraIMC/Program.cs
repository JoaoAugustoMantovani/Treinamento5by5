Console.WriteLine("Cálculo de IMC");
Console.WriteLine("----------------------");

Console.WriteLine("Insira seu peso em kg");
int peso = Int32.Parse(Console.ReadLine());

Console.WriteLine("Insira sua altura em cm");
float altura = float.Parse(Console.ReadLine());

float IMC = peso / ((altura / 100) * (altura / 100));

Console.WriteLine($"Seu IMC é: {IMC:F2}");

    if (IMC < 18.5)
    {
        Console.WriteLine("Seu IMC está constando: Baixo Peso");
    } else if(IMC > 18.5 && IMC < 24.9)
    {
        Console.WriteLine("Seu IMC está constando: Peso Adequado");
    } else if (IMC > 25 && IMC < 29.9)
    {
        Console.WriteLine("Seu IMC está constando: Sobrepeso");
    } else if (IMC > 30 && IMC < 34.9) 
    {
        Console.WriteLine("Seu IMC está constando: Obesidade grau I");
    } else if (IMC > 35 && IMC < 39.9)
    {
        Console.WriteLine("Seu IMC está constando: Obesidade grau II");
    } else if (IMC > 40)
    {
        Console.WriteLine("Seu IMC está constando: Obesidade grau III");
    }
