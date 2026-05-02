
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
        Console.WriteLine($"{Titular} Retiraste {monto}");
    }

    public void RecibirTransferencia(decimal monto)
    {
        if (monto <= 0){ 
            throw new ArgumentException("El monto debe mayor a cero.");
        }
        Saldo += monto;
        Console.WriteLine($"{Titular} Recibiste {monto}");
    }

    public void Transferir(decimal monto, ITransferible destino)
    {
        Retirar(monto);
        destino.RecibirTransferencia(monto);

        if (destino == null){ 
            throw new ArgumentException("Destino inválido");
            }
        if (destino.NumeroCuenta == this.NumeroCuenta){ 
            throw new InvalidOperationException("No se puede transferir a la misma cuenta");
            }
    }


}