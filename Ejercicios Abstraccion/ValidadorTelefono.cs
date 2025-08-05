using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Abstraccion
{
    public class ValidadorTelefono : IValidador
    {
        public string telefono { get; set; }
        public void EsValido(string telefono)
        {
            if (telefono.Length == 9 && telefono.Contains("-"))
            {
                Console.WriteLine("Numero de telefono Valido");
            }
            else
            {
                Console.WriteLine("Numero de telefono NO Valido");
            }
        }
    }
}

