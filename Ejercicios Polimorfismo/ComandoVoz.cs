using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Polimorfismo
{
    public class ComandoVoz
    {
        public virtual void Ejecutar()
        {
            Console.WriteLine("Se ha ejecutado Comando de Voz");
        }
    }
}
