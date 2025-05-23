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
    public partial class UC_endUserLbl_Check : UserControl
    {
        public Panel viewPanel { get; set; }
        private string LOTID = null;
        private string partNo { get; set; }
        private string icQty { get; set; }
        private string waferQty { get; set; }
        private string custLotNo { get; set; }
        private string shippingLbl { get; set; }
        private string expiryDate { get; set; }



        // Control의 부모 쪽으로 전달할 Event Delegate          
        public delegate void delResultEvent(ResultForwardArgs result);// delegate 선언    

        [Category("Furex")]
        [Description("Result가 발생하는 이벤트 입니다.")]
        public event delResultEvent ResultForward;// delegate event 선언
        protected virtual void OnResultForward(ResultForwardArgs e)
        {
            if (ResultForward != null)
                ResultForward(e);
        }

        public string LOT_ID
        {
            get { return LOTID; }
            set
            {
                try
                {
                    LOTID = value;
                    if (value != null && value != "")
                    {
                        PartNo = "PartNo";
                        IcQty = "1234";
                        WaferQty = "5678";
                        CustLotNo = "CustLotNo";
                        ShippingLbl = "ShpipingLabel";
                        string UVdate = "20250203101010";
                        DateTime tmpDate = DateTime.ParseExact(UVdate, "yyyyMMddHHmmss", null);
                        tmpDate = tmpDate.AddYears(2);
                        ExpiryDate = tmpDate.ToString("yyyy'/'MM'/'dd");

                        if (ShippingLbl == "") //정보있으면 활성화
                        {
                            shippingLlb_txt.Visible = false;
                            label5.Visible = false;
                            shippingLlb_txt.Enabled = false;
                        }


                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        public string PartNo
        {
            get
            {
                Console.WriteLine("get 실행");
                return partNo;
            }
            set
            {
                Console.WriteLine("set 실행");
                this.partNo_txt.Text = value;
                partNo = value;
            }
        }
        public string IcQty
        {
            get { return icQty; }
            set
            {
                icQty = value;
                this.icQty_txt.Text = value;
            }
        }
        public string WaferQty
        {
            get { return waferQty; }
            set
            {
                waferQty = value;
                this.waferQty_txt.Text = value;
            }
        }
        public string CustLotNo
        {
            get { return custLotNo; }
            set
            {
                custLotNo = value;
                this.custLotNo_txt.Text = value;
            }
        }
        public string ShippingLbl
        {
            get { return shippingLbl; }
            set
            {
                shippingLbl = value;
                this.shippingLlb_txt.Text = value;
            }
        }
        public string ExpiryDate
        {
            get { return expiryDate; }
            set
            {
                expiryDate = value;
                this.expiryDate_txt.Text = value;
            }
        }

        public UC_endUserLbl_Check()
        {
            InitializeComponent();
            InitializeControl();
        }
        public UC_endUserLbl_Check(string LOT_ID)
        {
            this.LOT_ID = LOT_ID;
        }
        private void UC_endUserLbl_Check_Load(object sender, EventArgs e)
        {
            partNo_txt.Focus();
        }

        private void InitializeControl()
        {
            Clear();
        }
        private void Clear()
        {
            partNo_txt.Text = "";
            icQty_txt.Text = "";
            waferQty_txt.Text = "";
            custLotNo_txt.Text = "";
            shippingLlb_txt.Text = "";
            expiryDate_txt.Text = "";
            partNo_txt.Enabled = true;
            icQty_txt.Enabled = false;
            waferQty_txt.Enabled = false;
            custLotNo_txt.Enabled = false;
            shippingLlb_txt.Enabled = false;
            expiryDate_txt.Enabled = false;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            OnResultForward(new ResultForwardArgs(viewPanel, false));
        }

        private void partNo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (partNo_txt.Text != partNo)
                    {
                        MessageBox.Show("Part No가 다릅니다. 확인하여 주세요!");
                        partNo_txt.Text = "";
                        partNo_txt.Focus();
                        return;
                    }
                    partNo_txt.Enabled = false;
                    icQty_txt.Enabled = true;
                    icQty_txt.Focus();
                }
            }
            catch (Exception ex)
            { 
                return;
            }
        }

        private void custLotNo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (custLotNo_txt.Text != custLotNo)
                    {
                        MessageBox.Show("LOT ID 값이 다릅니다. 확인하여 주세요!");
                        custLotNo_txt.Text = "";
                        custLotNo_txt.Focus();
                        return;
                    }
                    custLotNo_txt.Enabled = false;
                    if (true) //정보있으면 활성화
                    {
                        shippingLlb_txt.Enabled = true;
                        shippingLlb_txt.Focus();
                    }
                    else
                    {
                        expiryDate_txt.Enabled = true;
                        expiryDate_txt.Focus();
                    }
                }
            }
            catch (Exception ex)
            { 
                return;
            }
        }

        private void icQty_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (icQty_txt.Text != icQty)
                    {
                        MessageBox.Show("IC Qty 값이 다릅니다. 확인하여 주세요!");
                        icQty_txt.Text = "";
                        icQty_txt.Focus();
                        return;
                    }
                    icQty_txt.Enabled = false;
                    waferQty_txt.Enabled = true;
                    waferQty_txt.Focus();
                }
            }
            catch (Exception ex)
            { 
                return;
            }
        }

        private void shippingLlb_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (shippingLlb_txt.Text != shippingLbl)
                    {
                        MessageBox.Show("Shipping Label 값이 다릅니다. 확인하여 주세요!");
                        shippingLlb_txt.Text = "";
                        shippingLlb_txt.Focus();
                        return;
                    }
                    shippingLlb_txt.Enabled = false;
                    expiryDate_txt.Enabled = true;
                    expiryDate_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void waferQty_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (waferQty_txt.Text != waferQty)
                    {
                        MessageBox.Show("Wafer Qty 값이 다릅니다. 확인하여 주세요!");
                        waferQty_txt.Text = "";
                        waferQty_txt.Focus();
                        return;
                    }
                    waferQty_txt.Enabled = false;
                    custLotNo_txt.Enabled = true;
                    custLotNo_txt.Focus();
                }
            }
            catch (Exception ex)
            { 
                return;
            }
        }

        private void expiryDate_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (expiryDate_txt.Text != expiryDate)
                    {
                        MessageBox.Show("Expiry Date 값이 다릅니다. 확인하여 주세요!");
                        expiryDate_txt.Text = "";
                        expiryDate_txt.Focus();
                        return;
                    }
                    expiryDate_txt.Enabled = false;
                    OnResultForward(new ResultForwardArgs(viewPanel, true));
                }
            }
            catch (Exception ex)
            { 
                return;
            }
        }
    }

    public class ResultForwardArgs : EventArgs
    {
        public ResultForwardArgs(Panel viewPanel, bool result)
        {
            ViewPanel = viewPanel;
            ResultData = result;
        }
        public bool ResultData { get; set; }
        public Panel ViewPanel { get; set; }
    }
}
