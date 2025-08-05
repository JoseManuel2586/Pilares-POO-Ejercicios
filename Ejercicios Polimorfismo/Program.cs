using Ejercicios_Polimorfismo;
using System.Data;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Notificacion> notificaciones = new List<Notificacion>
        {
            new NotificacionEmail(),
            new NotificacionSMS(),
            new NotificacionPush()
        };

        foreach (var not in notificaciones)
        {
            not.Enviar();
        }
        Console.WriteLine("===========================================================================");

        List<ComandoVoz> comandoVoz = new List<ComandoVoz>
        {
            new EncenderLuces(),
            new ReproducirMusica(),
            new MostrarClima()
        };

        EjecutarComandoVoz(comandoVoz);
        
        Console.WriteLine("===========================================================================");

        List<Pago> registroDeFormasDePago = new List<Pago>
        {
            new PagoConTarjeta(),
            new PagoConEfectivo(),
            new PagoConTransferencia()
        };

        ProcesadorDePagos(registroDeFormasDePago);


        Console.ReadLine();

    }

    public static void EjecutarComandoVoz(List<ComandoVoz> comVoz)
    {
        foreach(var comando in comVoz)
        {
            comando.Ejecutar();
        }
    }

    public static void ProcesadorDePagos(List<Pago> pagos)
    {
        foreach (var pago in pagos)
        {
            pago.ProcesarPago(); 
        }
    }
        
}        

