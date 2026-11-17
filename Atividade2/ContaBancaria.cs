public class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public void setTitular(string titular)
    {
        this.Titular = titular;
    }

    public string getTitular()
    {
        return this.Titular;
    }

    public double getSaldo()
    {
        return this.Saldo;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            this.Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Valor inválido para depósito.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= this.Saldo)
        {
            this.Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido para saque.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual de {this.Titular}: R$ {this.Saldo:F2}");
    }

    public override string ToString()
    {
        return $"Titular: {this.Titular}\nSaldo: R$ {this.Saldo:F2}";
    }
}
