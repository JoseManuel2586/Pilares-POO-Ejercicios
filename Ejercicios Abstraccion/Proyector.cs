using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Abstraccion
{
    public class Proyector: DispositivoSalida
    {
        public string proyector;

        public override void MostrarMensaje(string proyector)
        {
            Console.WriteLine($"Lanzando proyeccion: {proyector}");
        }
    }
}
