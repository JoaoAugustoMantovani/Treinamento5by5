public class ContaCorrente : ContaBancaria
{
    public double Limite { get; set; }

    public ContaCorrente(int numero, double saldo) : base(numero, saldo)
    {
        Numero  = numero;
        Saldo = saldo;
    }

    public double setLimite(double saldo)
    {
        if (saldo <= 0)
            return Limite = 0;
        else 
            return Limite = (Saldo * 3); 
    }

    public override bool Depositar(double valor)
    {
        if (valor >= 0)
        {
            Saldo += valor;
            setLimite(Saldo);
            return true;
        }
        else
            return false;
    }

    public override bool Sacar(double valor)
    {
        if (valor <= Saldo + Limite)
        {
            Saldo -= valor;
            setLimite(Saldo);
            return true;
        }
        else
            return false;
    }
    public override bool Transferir(ContaBancaria contaTransferir, ContaBancaria contaReceber, double valor)
    {
        if (contaTransferir.Saldo >= valor)
        {
            contaTransferir.Saldo -= valor;
            contaReceber.Saldo += valor;
            setLimite(Saldo);
            return true;
        }
        else
            return false;
    }

    public override bool Pagar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            setLimite(Saldo);
            return true;
        }
        else
            return false;
    }
}

