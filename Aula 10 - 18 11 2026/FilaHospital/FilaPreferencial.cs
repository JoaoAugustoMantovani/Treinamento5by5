class FilaPreferencial
{
    public Fila Head;
    public Fila Tail;
    public int Contador;
    public FilaPreferencial()
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

    public void InserirElemento(Fila aux)
    {
        if (FilaVazia())
        {
            Head = aux;
            Tail = aux;
        }
        else
        {
            Tail.Proximo = aux;
            Tail = aux;
        }
        Contador++;
    }

    public int GetContador()
    {
        return Contador;
    }

    public void RemoverElemento()
    {
        if (Head == null)
        {
            return;
        }

        Head = Head.Proximo;
        Contador--;

        if (Head == null)
        {
            Tail = null;
        }
    }

    public void MostrarFila()
    {
        Fila p = Head;

        for (int i = 0; i <= Contador; i++)
        {
            if (p == null)
            {
                //Console.WriteLine(Head.Nome);
                Console.WriteLine("Acabou a fila!");
                break;
            }
            Console.Write(p.Senha + " => ");
            p = p.Proximo;
            //Console.WriteLine(Tail.Nome);
        }
        Console.WriteLine();
    }

}


