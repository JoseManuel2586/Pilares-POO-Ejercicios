using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia.Ejercicios_Herencia
{
    public class Gerente: Empleado
    {
        public Gerente(string nombre, double salario) : base(nombre, salario)
        {
        }

        public void TomarDesicion()
        {
            Console.WriteLine($"{nombre} ha tomado una desición");
        }

    }
}
