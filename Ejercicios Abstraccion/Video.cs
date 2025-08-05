using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Abstraccion
{
    public class Video: ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Se esta reproduciendo el video deseado");
        }
    }
}
