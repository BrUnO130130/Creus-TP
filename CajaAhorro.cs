using System.Security.Cryptography.X509Certificates;

public class CajaAhorro : Cuenta, ITransferible
{
    public CajaAhorro(string numeroCuenta, string titular, decimal saldoInicial)
        : base(numeroCuenta, titular, saldoInicial)
    {
    }

    public override void Retirar(decimal monto)
    {
        if (monto <= 0)
            throw new ArgumentException("El monto a retirar debe ser positivo.");
        if (monto > Saldo)
            throw new InvalidOperationException("Fondos insuficientes para retirar.");
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