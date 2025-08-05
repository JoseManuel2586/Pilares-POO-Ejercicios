using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares_POO_Ejercicios.Clases
{
    public class Empleado
    {
        private string nombre;
        private double salario;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }
        public double Salario
        {
            get { return salario; }
            set
            {
                if (value >= 0)
                {
                    salario = value;
                }
            }
        }

        public  Empleado(string nombre , double salario )
        {
            this.Nombre = nombre;
            this.Salario = salario;
        }
    }

}
