using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia.Ejercicios_Herencia
{
    public class CuentaCorriente: Cuenta
    {
        public double CalcularIntereses()
        {
            saldo = saldo * 1.20;
            return saldo;
        }
        

    }
}
