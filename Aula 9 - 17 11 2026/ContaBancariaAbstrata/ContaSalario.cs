internal class ContaSalario : ContaBancaria
{
    public ContaSalario(int numero, double saldo) : base(numero, saldo)
    {
        Numero = numero;
        Saldo = saldo;
    }
}

