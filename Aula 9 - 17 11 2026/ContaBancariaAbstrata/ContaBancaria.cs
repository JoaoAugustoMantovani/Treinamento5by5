public abstract class ContaBancaria
{
    public int Numero { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(int numero, double saldo)
    {
        Numero = numero;
        Saldo = saldo;
    }

    public virtual bool Depositar(double valor)
    {
        if (valor >= 0)
        {
            Saldo += valor;
            return true;
        }
        else 
            return false;
    }

    public virtual bool Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            return true;
        }
        else 
            return false;
    }
    public virtual bool Transferir(ContaBancaria contaTransferir, ContaBancaria contaReceber, double valor)
    {
        if (contaTransferir.Saldo >= valor)
        {
            contaTransferir.Saldo -= valor;
            contaReceber.Saldo += valor;
            return true;
        }
        else 
            return false;
    }

    public virtual bool Pagar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            return true;
        }
        else
            return false;
    }
}

