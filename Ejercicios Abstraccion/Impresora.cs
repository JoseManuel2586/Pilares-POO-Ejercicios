using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Abstraccion
{
    public class Impresora: DispositivoSalida
    {
        string impresora;

        public override void MostrarMensaje(string impresora)
        {
            Console.WriteLine($"Imprimiendo Mensaje: {impresora}");
        }
    }
}
