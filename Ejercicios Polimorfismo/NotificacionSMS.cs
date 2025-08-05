using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Polimorfismo
{
    public class NotificacionSMS: Notificacion
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando SMS...");
        }
    }
}
