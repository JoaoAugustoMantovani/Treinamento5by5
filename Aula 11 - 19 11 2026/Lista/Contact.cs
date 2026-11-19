public class Contact(string nome)
{
    //public int Id { get; set; }
    public string Name { get; private set; } = nome;
    public string Phone { get; set; }
    public char Gender { get; set; }
}

