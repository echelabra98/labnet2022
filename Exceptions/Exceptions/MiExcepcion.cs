using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string message) : base(message)
        {
            
            
        }

        public override string Message => $"Hola, soy una excepcion {base.Message}  \n";
    }
}
