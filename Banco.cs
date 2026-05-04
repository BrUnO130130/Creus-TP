//using System;
//using System.Collections.Generic;
//using System.Linq;

public class Banco
{
    private List<Cuenta> cuentas = new List<Cuenta>();

    //creacion de la lista donde se guardan todas las cuentas

    public void AgregarCuenta(Cuenta cuenta)
    {
        if (cuenta == null){
            throw new ArgumentException("La cuenta no puede ser null");
        }
        if (cuentas.Any(c => c.NumeroCuenta == cuenta.NumeroCuenta)){
            throw new InvalidOperationException("Ya existe una cuenta con ese número");
        }
        cuentas.Add(cuenta);
    } 
    //metodo para agregar las cuentas a la lista con validaciones

    public void MostrarReporte()
    {
        Console.WriteLine("\n--- REPORTE DE CUENTAS ---");

        foreach (var c in cuentas)
        {
            Console.WriteLine(c);
        }
    }
    //metodo para mostrar el resumen de las cuentas con un foreach
}