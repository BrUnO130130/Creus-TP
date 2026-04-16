abstract class Cuenta
{
    String TipoCuenta;
    double Saldo;
    String Titular;
    int CBU;
}

public interface ITransferible
{
    void Transferir(decimal monto, ITransferible destino);
    string NumeroCuenta { get; }
}