Carro CadastrarCarros()
{
    Console.WriteLine("Digite o fabricante: ");
    string fabricante = Console.ReadLine();
    Console.WriteLine("Digite o Modelo");
    string modelo = Console.ReadLine();
    Console.WriteLine("Digite o Ano de fabricação");
    int anoDeFab = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o Ano de Modelo");
    int anoDeModelo = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o Valor");
    int valor = int.Parse(Console.ReadLine());

    Carro carro1 = new(fabricante, modelo, anoDeFab, anoDeModelo, valor);

    return carro1;
}

Carro[] carros = new Carro[4];

for (int i = 0; i < 4; i++)
{
    carros[i] = CadastrarCarros();
}

for (int j = 0; j < 4; j++)
{
    Console.WriteLine(carros[j].ToString());
}

Console.ReadKey();


