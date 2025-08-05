using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Polimorfismo
{
    public class EncenderLuces: ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Las Luces fueron encendidas");
        }    
        
    }
}
