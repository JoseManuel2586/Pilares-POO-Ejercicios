using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Abstraccion
{
    public class Cancion: ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Usted ha puesto a reproducir la cancion solicitada");
        }
    }
}
