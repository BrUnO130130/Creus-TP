public interface ITransferible
{
    void Transferir(decimal monto, ITransferible destino);
    string NumeroCuenta { get; }
}