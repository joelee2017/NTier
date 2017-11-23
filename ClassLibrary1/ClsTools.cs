using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class ClsTools
    {
        public ClsTools()
        {

        }


        public virtual int ClsTools1(int Oil, int Mile)
        {
            return Oil * Mile;
        }

        protected  int m_Oil;
        public int Oil
        {
            get
            {
                return m_Oil;
            }
            set
            {
                if (value >= 0)
                {
                    m_Oil = value;
                }
            }
        }

        protected int m_Mile;
        public int Mile
        {
            get
            {
                return m_Mile;
            }
            set
            {
                if (value >= 0)
                {
                    m_Mile = value;
                }
            }
        }


        
    }
}
