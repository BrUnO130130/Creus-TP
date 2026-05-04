public abstract class Cuenta : ITransferible
{
    public string NumeroCuenta { get; private set;}
    public string Titular { get; private set;}
    public decimal Saldo { get; protected set;}

    public Cuenta(string numeroCuenta, string titular, decimal saldoInicial)
    {
        if (saldoInicial < 0)
            throw new ArgumentException("El saldo inicial no puede ser negativo.");
        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("El titular no puede estar vacío.");
        if (string.IsNullOrWhiteSpace(numeroCuenta))
            throw new ArgumentException("El número de cuenta no puede estar vacío.");

        NumeroCuenta = numeroCuenta;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public abstract void Retirar(decimal monto);   
    public void Transferir(decimal monto, ITransferible destino)
    {
        if (destino == null)
            throw new ArgumentNullException(nameof(destino), "El destino no puede ser nulo.");
        if (monto <= 0)
            throw new ArgumentException("El monto a transferir debe ser mayor que cero.");

        Retirar(monto);
        ((Cuenta)destino).Depositar(monto);
    }

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
            throw new ArgumentException("El monto a depositar debe ser mayor que cero.");
        Saldo += monto;
    }

    public override string ToString()
    {
        return $"CBU: {NumeroCuenta}, Titular: {Titular}, Saldo: {Saldo:C}";
    }
}