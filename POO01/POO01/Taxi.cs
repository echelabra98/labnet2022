using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO01
{
    public class Taxi : TransportePublico
    {
        public Taxi (int pasajeros) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return "";
        }

        public override string Detenerse()
        {
            return "";
        }
    }
}
