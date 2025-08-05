using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Polimorfismo
{
    public class Pago
    {
        public virtual void ProcesarPago()
        {
            Console.WriteLine("El pago fue procesado");
        }
    }
}
