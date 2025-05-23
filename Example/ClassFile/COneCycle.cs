using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Example
{
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1;    // 바퀴        
        public Rectangle _rtSquare1;   // 몸통
        
        public COneCycle(string sName)
        {
            strName = sName;
            _pen = new Pen(Color.Blue, 3);

            _rtCircle1 = new Rectangle(120, 150, 120, 120);  // 바퀴1에 대한 위치 및 크기를 설정           
            _rtSquare1 = new Rectangle(150, 30, 60, 120);  // 몸통1에 대한 위치 및 크기를 설정        
        }

        public Pen FpenInfo()
        {
            return _pen;
        }

        public override void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSquare1Move(iMove);
        }

        protected void fCircle1Move(int iMove)
        {
            Point oPoint = _rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle1.Location = oPoint;
        }
        protected void fSquare1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare1.Location = oPoint;
        }
    }
}
