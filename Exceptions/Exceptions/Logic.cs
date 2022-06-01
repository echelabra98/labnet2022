using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Logic
    {
        public void LanzarExcepcion()
        {
            throw new NotImplementedException();
        }

        public void LanzarCustom()
        {
            throw new MiExcepcion("Excepcion personalizada  \n");
        }
    }
}
