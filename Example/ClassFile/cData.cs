using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    /// <summary>
    /// 변수
    /// </summary>
    partial class cData
    {
        private double _dTotalPrice = 0.0;
        private string _strItem = "";
        private int _iRate = 0;
        private int _iCount = 0;
        private string _strErrorName = "";

        public double DTotalPrice
        {
            get => _dTotalPrice;
            set
            {
                _dTotalPrice = _dTotalPrice + value;
            }
        }

        public string StrItem
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _strErrorName = "물건이 선택되지 않았습니다.";
                }
                _strItem = value;
            }
        }

        public int IRate
        {
            set
            {
                if (value > 20)
                {
                    _strErrorName = "사장님만 가능 한 할인 입니다.";
                }
                else
                {
                    _iRate = value;
                }
            }
        }

        public int ICount
        {
            set
            {
                if (value > 5)
                {
                    _strErrorName = "개별 품복은 5개 이상 살 수 없습니다.";
                }
                else if (value == 0)
                {
                    _strErrorName = "물품의 개수가 0개 입니다.";
                }
                else
                {
                    _iCount = value;
                }
            }
        }

        public string StrErrorName
        {
            get => _strErrorName;
        }
    }

    /// <summary>
    /// 수식 계산
    /// </summary>
    partial class cData
    {
        public double fItemPrice()
        {
            double dPrice = 0;
            int iTemPrice = 0;

            if (String.IsNullOrEmpty(_strErrorName))
            {
                iTemPrice = (int)Enum.Parse(typeof(EnumItem), _strItem);
                dPrice = iTemPrice - Math.Round((double)iTemPrice * (double)_iRate / 100, 2);
            }
            return dPrice * _iCount;
        }

    }
    /// <summary>
    /// 문자열
    /// </summary>
    partial class cData
    {
        public string fResult(double dPrice)
        {
            if (_iRate == 0)
            {
                return string.Format("{0} X {1} : {2}원", _strItem, _iCount, dPrice);
            }
            else
            {
                return string.Format("{0} X {1} : {2}원 (할인율 : {3}%)", _strItem, _iCount, dPrice, _iRate);
            }
        }
        public void fDataClear()
        {
            _strErrorName = string.Empty;
            _strItem = string.Empty;
            _iRate = 0;
            _iCount = 0;
        }
    }
}
