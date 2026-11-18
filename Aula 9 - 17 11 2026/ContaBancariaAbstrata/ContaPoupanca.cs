public class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(int numero, double saldo) : base(numero, saldo)
    {
        Numero = numero;
        Saldo = saldo;
    }

    public override bool Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= (valor * 1.05);
            return true;
        }
        else
            return false;
    }

}

