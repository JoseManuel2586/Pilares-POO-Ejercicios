using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Abstraccion
{
    public class ValidadorEmail: IValidador
    {
        public string email {  get; set; }
        public void EsValido(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                Console.WriteLine("Correo Valido");
            }
            else
            {
                Console.WriteLine("Correo NO Valido");
            }
        }
    }
}
