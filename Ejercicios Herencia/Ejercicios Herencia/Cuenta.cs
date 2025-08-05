using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia.Ejercicios_Herencia
{
    public class Cuenta
    {
        protected double saldo {  get; set; }
        public void Depositar(double monto)
        {
            if(monto > 0)
            {
                saldo += monto;
            }
            else
            {
                Console.WriteLine("no se puede depositar un valor menor a cero");
            }
        }

    }
}
