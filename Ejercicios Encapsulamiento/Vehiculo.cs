using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pilares_POO_Ejercicios.Clases_Ejercicio_1
{
    public class Vehiculo
    {
        private bool encendido;

        public Vehiculo(bool encendido)
        {
            this.encendido = encendido;
        }
        public void Encender()
        {
            if (encendido)
            {
                Console.WriteLine("El vehiculo se encuentra encendido");

            } else { Console.WriteLine("Debe encender el Vehiculo"); }
        }

        public void Apagar()
        {
            if (!encendido)
            {
                Console.WriteLine("El vehiculo se encuentra apagado");

            }
            else { Console.WriteLine("Debe apagar el Vehiculo"); }
        }
    }
}
