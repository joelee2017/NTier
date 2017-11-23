using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class ClsSailBoat:ClsBoat
    {
        public ClsSailBoat()
        {

        }

        public override int ClsTools1(int Oil, int Mile)
        {
            return Oil * Mile;
        }
    }
}
