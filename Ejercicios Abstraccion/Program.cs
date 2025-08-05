using Ejercicios_Abstraccion;

internal class Program
{
    private static void Main(string[] args)
    {

        List<ArchivoMultimedia> multimedia = new List<ArchivoMultimedia>
        {
            new Video(),
            new Cancion(),
            new AudioLibro()
        };


        foreach(var archivo in multimedia)
        {
            archivo.Reproducir();
        }
        Console.WriteLine("-------------------------------------------------------------------------");

        List<IValidador> validaciones = new List<IValidador>
        {
            new ValidadorEmail(),
            new ValidadorTelefono(),
            new ValidadorDPI()
        };

        validaciones[0].EsValido("jose_lopez2586@hotmail.com");
        validaciones[0].EsValido("jose_lopez2586hotmail.com");
        validaciones[1].EsValido("3843-6159");
        validaciones[1].EsValido("38436159");
        validaciones[2].EsValido("2441732730101");
        validaciones[2].EsValido("244173273010");


        Console.WriteLine("-------------------------------------------------------------------------");

        List<DispositivoSalida> mensajesDispositivos = new List<DispositivoSalida> { 
        
            new Pantalla(),
            new Proyector(),
            new Impresora()
        };

        foreach(var mensaje in mensajesDispositivos)
        {
            mensaje.MostrarMensaje("Bienvenido al curso de programacion 2");
        }

        
        Console.ReadLine();

    }

}