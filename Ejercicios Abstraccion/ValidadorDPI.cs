using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Abstraccion
{
    public class ValidadorDPI: IValidador
    {
        public string dpi { get; set; }
        public void EsValido(string dpi)
        {
            if (dpi.Length == 13)
            {
                Console.WriteLine("Numero de DPI Valido");
            }
            else
            {
                Console.WriteLine("Numero de DPI NO Valido");
            }
        }
    }
}
