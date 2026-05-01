class Program
{
    static void Main(string[] args)
    {
        Banco banco = new Banco();

        try
        {
            var caja = new CajaAhorro("001", "Juan", 1000);
            var corriente = new CuentaCorriente("002", "Ana", 500, -10000);

            banco.AgregarCuenta(caja);
            banco.AgregarCuenta(corriente);

            caja.Depositar(500);
            caja.Retirar(200);

            caja.Transferir(300, corriente);

            caja.Retirar(5000);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        banco.MostrarReporte();
    }
}