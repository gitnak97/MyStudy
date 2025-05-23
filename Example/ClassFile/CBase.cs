using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Example
{
    class CBase
    {
        public string strName { get; set; }
        protected Pen _pen;
       

        public CBase()
        {
            
        }

        public virtual void fMove(int iMove)
        {
            
        }

    }
}
