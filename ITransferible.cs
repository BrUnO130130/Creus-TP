public interface ITransferible
{
    string NumeroCuenta { get; }
    void Transferir(decimal monto, ITransferible destino);
    void RecibirTransferencia(decimal monto);
}