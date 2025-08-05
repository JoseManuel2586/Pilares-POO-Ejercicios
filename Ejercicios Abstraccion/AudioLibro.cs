using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Abstraccion
{
    public class AudioLibro: ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Se ha puesto a reproducir el audio libro solicitado");
        }
    }
}
