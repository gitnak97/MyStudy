using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class CPlayer
    {
        public CPlayer()
        {
            iCount = 0;
            iSun = 0;
            iMoon = 0;
            iStar = 0;
            iCardSum = 0;
        }

        public int iCount; // player가 몇회 진행 중인지

        public int iSun;    // 해에 대한 값
        public int iMoon;   // 달에 대한 값
        public int iStar;   // 별에 대한 값

        public int iCardSum;    // 해, 달, 별을 더한 값

        public int CardSun(int iSum, int iMoon, int iStar)
        {
            return iSum + iMoon + iStar;
        }

        public string ResultText()
        {
            return string.Format("{0}회 ) 해 : {1}, 달 : {2}, 별 : {3}  => 합계는 {4} 입니다.", this.iCount, this.iSun, this.iMoon, this.iStar, this.iCardSum);
        }

    }
}
