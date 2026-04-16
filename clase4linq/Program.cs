/*
int[] numeros = { 1, 2, 3, 4 ,5 ,6 ,7 ,8 ,9 ,10 ,11 ,12 ,13 ,14, 15, 16, 17, 18, 19, 20};

var pares = numeros.Where(n => n % 3 == 0);

var descendente = pares.OrderByDescending(n => n);

Console.Write("Los numeros Ordenados en Descendente: ");
foreach (var n in descendente)
{
Console.Write($"{n} ");
}
*/

/*
var estudiantes = new List<Estudiante>
{
new("Ana", 8.5),
new("Luis", 4.0),
new("María", 6.0),
new("Carlos", 3.5),
};
var mensajes = estudiantes.Select(e => 
    $"Hola {e.Nombre}, {(e.Nota >= 6 ? "Aprobado" : "Desaprobado")}"
);

foreach (var n in mensajes)
{
    Console.WriteLine(n);
}

record Estudiante(string Nombre, double Nota);
*/
/*
var productos = new List<Producto>
{
new("Aceitunas", 500)
};

foreach (var n in productos)
{
    Console.WriteLine($"Nombre: {n.Nombre}");
}
public record Producto(string Nombre, decimal Precio);
*/
/*
string? input = Console.ReadLine();

int largoString = input?.Length ?? 0;

Console.WriteLine($"{largoString}");
*/

int[] numeros = { 1, 2, 3, 4 ,5 ,6 ,7 ,8 ,9 ,10};

var mayor = numeros.Where(n => n > 5);

var descendente = mayor.OrderByDescending(n => n);

Console.Write("Los numeros Ordenados en Descendente: ");
foreach (var n in descendente)
{
Console.Write($"{n} ");
}