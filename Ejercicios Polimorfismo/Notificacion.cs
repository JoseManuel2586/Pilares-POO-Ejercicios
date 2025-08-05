using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Polimorfismo
{
    public class Notificacion
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Enviando informacion");
        }
    }
}
