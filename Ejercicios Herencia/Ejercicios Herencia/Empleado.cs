using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia.Ejercicios_Herencia
{
    public class Empleado
    {

        protected string nombre;
        private double salario;

        public Empleado(string nombre, double salario)
        {
            this.nombre = nombre; 
            this.salario = salario;
        }
    }
}
