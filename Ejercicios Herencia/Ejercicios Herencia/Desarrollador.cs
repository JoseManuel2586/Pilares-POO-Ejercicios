using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia.Ejercicios_Herencia
{
    public class Desarrollador: Empleado
    {
        public Desarrollador(string nombre, double salario) : base(nombre, salario)
        {
        }

        public void Programar()
        {
            Console.WriteLine($"{nombre} se encuentra programando");
        }

    }
}
