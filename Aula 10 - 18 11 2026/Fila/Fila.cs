public class Fila
{
    public Pessoa Head;
    public Pessoa Tail;
    public int Contador;
    public Fila()
    {
        Head = Tail = null;
        Contador = 0;
    }

    public bool FilaVazia()
    {
        if (Head == null)
            return true;
        return false;
    }

    public void InserirElemento(Pessoa aux)
    {
        if (FilaVazia())
        {
            Head = aux;
            Tail = aux;
        }
        else
        {
            Tail.Proximo = aux;

        }
    }

    public int GetContador()
    {
        return Contador;
    }

    public void RemoverElemento()
    {
        if (!FilaVazia())
        {
            Head = Head.Proximo;
            Contador--;
        }
    }

    public void MostrarFila()
    {
        Pessoa p = Head;
        for (int i = 0; i <= Contador; i++)
        {
            if (p == null)
            {
                Console.WriteLine("Acabou a fila");
                break;
            }
            Console.WriteLine(p.Nome + " => ");
            p = p.Proximo;
        }
        Console.WriteLine();
    }
}
