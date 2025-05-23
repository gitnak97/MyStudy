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
    public partial class ListClass : Form
    {
        


        ListUtil _listUtil = new ListUtil();

        public ListClass()
        {
            InitializeComponent();
        }


        private void pBox_Click(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;

            if (pBox?.Tag is string foodkey)
            {
                _listUtil[foodkey].Count++;
                ViewLabelCount();
                ViewTotalCount();
            }
        }

        private void ViewLabelCount()
        {
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl is Label lbl && lbl.Tag is string foodkey)
                {
                    lbl.Text = _listUtil[foodkey].Count.ToString();
                }
            }
        }

        void ViewTotalCount()
        {
            int iTotal = 0;
            foreach (var item in _listUtil)
            {
                iTotal += item.Value.Count;
            }

            lblTotalCount.Text = iTotal.ToString();
        }
       
    }
}
