using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Pilares_POO_Ejercicios.Clases_Ejercicio_1
{
    public class CuentaBancaria
    {
        private double saldo;
        
        public void Depositar(double monto)
        {
            if(monto > 0)
            {
                saldo += monto;
            }
        }

        public void Retirar(double monto)
        {
            if(monto > 0 && monto <= saldo && monto == 100)
            {
                saldo -= monto;
            }
            else
            {
                Console.WriteLine("El monto a retirar diario es de 100");
            }
        }
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
