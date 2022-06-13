using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpN5.EF.Data;

namespace TpN5.EF.Logic
{
    public class BaseLogic
    {
        public readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
