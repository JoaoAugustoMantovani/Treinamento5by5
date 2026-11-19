class Pilha
{
    public Money Head { get; set; }

    public bool IsEmpty()
    {
        return Head is null;
    }

    public void AddElement(Money money)
    {
        money.Next = Head;
        Head = money;
    }

    public void RemoveElement()
    {
        Head = Head.Next;
    }

}

