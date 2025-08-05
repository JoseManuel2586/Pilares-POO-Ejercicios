using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Polimorfismo
{
    public class PagoConEfectivo: Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Recibiendo efectivo...");
        }
    }
}
