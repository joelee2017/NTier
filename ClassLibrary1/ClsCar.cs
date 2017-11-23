using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public  class ClsCar:ClsTools
    {
        public ClsCar()
        {

        }

        public override int ClsTools1(int Oil, int Mile)
        {
            return Oil * (Mile * 5);
        }

    }
}
