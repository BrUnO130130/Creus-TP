public abstract class Cuenta
{
    public string NumeroCuenta { get; protected set; }
    public string Titular { get; protected set; }
    public decimal Saldo { get; protected set; }

    public Cuenta(string numeroCuenta, string titular, decimal saldoInicial)
    {
        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("El titular no puede estar vacío.");
        if (saldoInicial < 0)
            throw new ArgumentException("El saldo inicial no puede ser negativo.");

        NumeroCuenta = numeroCuenta;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
            throw new ArgumentException("El monto a depositar debe ser positivo.");
        Saldo += monto;
    }

    public abstract void Retirar(decimal monto);

    public override string ToString()
    {
        return $"CBU: {NumeroCuenta} | Titular: {Titular} | Saldo: {Saldo:C}";
    }
}