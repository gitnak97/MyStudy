using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class EnumClass : Form
    {
        cData _Data = new cData();
        public EnumClass()
        {
            InitializeComponent();
        }

        private void EnumClass_Load(object sender, EventArgs e)
        {
            var EnumItem = Enum.GetValues(typeof(EnumItem));
            var EnumRate = Enum.GetValues(typeof(EnumRate));
            foreach (var item in EnumItem)
            {
                cboxItem.Items.Add(item.ToString());
            }
            foreach (var rate in EnumRate)
            {
                cboxRate.Items.Add(rate.ToString());
            }

        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Data.fDataClear();

            _Data.StrItem = cboxItem.Text;
            _Data.IRate = (int)Enum.Parse(typeof(EnumRate), cboxRate.Text);
            _Data.ICount = (int)numCount.Value;

            if (!String.IsNullOrEmpty(_Data.StrErrorName))
            {
                tboxErrorMsg.Text = _Data.StrErrorName;
                return;
            }
            double dPrice = _Data.fItemPrice();
            lboxItem.Items.Add(_Data.fResult(dPrice));
            _Data.DTotalPrice = dPrice;
            tboxResult.Text = _Data.DTotalPrice.ToString() + "원";

        }
    }
}
