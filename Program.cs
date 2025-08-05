using Pilares_POO_Ejercicios.Clases;
using Pilares_POO_Ejercicios.Clases_Ejercicio_1;

internal class Program
{
    private static void Main(string[] args)
    {


        Empleado empleado = new Empleado("Jose Manuel", -1800);
        Console.WriteLine("Nombre: " + empleado.Nombre + " " + "Salario: " + empleado.Salario);


        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Depositar(500);
        cuenta.Retirar(200);
        Console.WriteLine(cuenta.MostrarSaldo());



        Vehiculo vehiculo = new Vehiculo(true);
        Vehiculo vehiculo1 = new Vehiculo(false);
        vehiculo.Encender();
        vehiculo1.Apagar();


        Console.ReadLine();
        
    }
}