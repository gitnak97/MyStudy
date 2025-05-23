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
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tNumber1.Text);
            int iNumB = int.Parse(tNumber2.Text);

            int iResult = iNumA + iNumB;
            tAnswer.Text = iResult.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string test = String.Format("준호와 보기로 햇어용"); 
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }
    }
}
