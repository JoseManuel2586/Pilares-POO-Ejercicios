using Ejercicios_Herencia.Ejercicios_Herencia;
public class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("==================================================================");
        Gerente gerente = new Gerente("Jose Manuel", 1500.00);
        gerente.TomarDesicion();

        Desarrollador desarrollador = new Desarrollador("JMLopez", 2000.00);
        desarrollador.Programar();

        Console.WriteLine("==================================================================");
        Auto auto = new Auto();
        auto.Avanzar();
        auto.EncenderRadio();
        Console.WriteLine("------------------------------------------------------------------");
        Motocicleta motocicleta = new Motocicleta();
        motocicleta.Avanzar();
        motocicleta.HacerCaballito();

        Console.WriteLine("==================================================================");
        CuentaCorriente cuentaCorriente = new CuentaCorriente();
        cuentaCorriente.Depositar(250);
        Console.WriteLine("El Saldo mas Intereses es de: " + cuentaCorriente.CalcularIntereses());
        Console.WriteLine("------------------------------------------------------------------");
        CuentaAhorro cuentaAhorro = new CuentaAhorro();
        cuentaAhorro.Depositar(500);
        Console.WriteLine("El Saldo mas Intereses es de: " + cuentaAhorro.CalcularIntereses());


        Console.ReadLine();
    }
}