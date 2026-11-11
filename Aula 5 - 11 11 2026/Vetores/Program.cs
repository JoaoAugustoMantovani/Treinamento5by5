int[] numbers = new int[4];
int contador = 0;

void PopulaVetor()
{
do
{
    Console.WriteLine($"Informe o numero que deseja na posicao{contador}");
    numbers[contador] = int.Parse(Console.ReadLine());
    contador++;

} while (contador < numbers.Length);
}