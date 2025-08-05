using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Abstraccion
{
    public class Pantalla: DispositivoSalida
    {
        public string pantalla;
        public override void MostrarMensaje(string pantalla)
        {
            Console.WriteLine($"{pantalla}");
        }
    }
}
