using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Banco banco = new Banco();

       
            var caja = new CajaAhorro("001", "Juan", 1000);
            var corriente = new CuentaCorriente("002", "Ana", 500, -10000);
            var corriente2 = new CuentaCorriente("003", "Bruno", 5000, -10000);
            var caja2 = new CajaAhorro("004", "Maria", 350);

        // instanciando los objetos de las clases CajaAhorro y CuentaCorriente
        try
        {

            banco.AgregarCuenta(caja);
            banco.AgregarCuenta(corriente);
            banco.AgregarCuenta(corriente2);
            banco.AgregarCuenta(caja2);

            //agregando los objetos a la lista Cuentas con el metodo AgregarCuenta

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine("----------------------");
        try{
            caja2.Depositar(350);        
            caja.Depositar(500);
            corriente2.Depositar(0);  
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine("----------------------");
        try{
            caja.Retirar(200);
            caja2.Retirar(800);
            caja.Retirar(5000); 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine("----------------------");
        try{
            caja.Transferir(300, corriente);
            corriente2.Transferir(7000, caja2);
            caja.Transferir(500, caja);               
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }    
        Console.WriteLine("----------------------");

        //probando los distintos metodos Transferir, Depositar y Retirar
        //con try catch para simular los errores y que no se corte la ejecucion

        banco.MostrarReporte();

        //mostrando el estado final de las cuentas con el metodo MostrarReporte
    }
}