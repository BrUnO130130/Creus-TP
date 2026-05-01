
public class CuentaCorriente : Cuenta, ITransferible
{
    decimal limiteDescubierto = -10000;
    public CuentaCorriente (string numeroCuenta, string titular, decimal saldoInicial, decimal limiteDescubierto)
        : base(numeroCuenta, titular, saldoInicial)
    {
        this.limiteDescubierto = limiteDescubierto;
    }

    public override void Retirar(decimal monto)
    {
        if (monto <= 0)
            throw new ArgumentException("El monto a retirar debe ser positivo.");
        if (Saldo - monto < limiteDescubierto)
            throw new InvalidOperationException($"Límite de descubierto alcanzado. Límite: {limiteDescubierto:C}");
        Saldo -= monto;
    }

    public void RecibirTransferencia(decimal monto)
    {
        if (monto <= 0)
            throw new ArgumentException("El monto debe mayor a cero.");
        Saldo += monto;
    }

    public void Transferir(decimal monto, ITransferible destino)
    {
        Retirar(monto);
        destino.RecibirTransferencia(monto);
    }


}