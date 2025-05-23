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
    public partial class DataType : Form
    {
        public DataType()
        {
            InitializeComponent();
        }

        private void btntBox_Click(object sender, EventArgs e)
        {

        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            short sNumber = short.Parse(tBoxNumber.Text);
            lblShort.Text = sNumber.ToString();  
        }

        private void btnInt_Click(object sender, EventArgs e)
        {

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {

        }
    }
}
