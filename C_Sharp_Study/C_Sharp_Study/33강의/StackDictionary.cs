using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Study._33강의
{
    public partial class StackDictionary : Form
    {
        public StackDictionary()
        {
            InitializeComponent();
        }


        Dictionary<string, Stack<CSize>> oDic = new Dictionary<string, Stack<CSize>>();

        private void ControlSizeRead()
        {
            oDic.Clear();

            //Button 등록
            Stack<CSize> sButton = new Stack<CSize>();
            foreach (var obtn in groupBox1.Controls.OfType<Button>())
            {
                CSize oSize = new CSize();
                oSize.Name = obtn.Name;
                oSize.Height = obtn.Height;
                oSize.Width = obtn.Width;

                sButton.Push(oSize);
            }

            oDic.Add("BUTTON", sButton);

            Stack<CSize> sLabel = new Stack<CSize>();
            foreach (var obtn in groupBox1.Controls.OfType<Label>())
            {
                CSize oSize = new CSize();
                oSize.Name = obtn.Name;
                oSize.Height = obtn.Height;
                oSize.Width = obtn.Width;

                sButton.Push(oSize);
            }

            oDic.Add("LABEL", sLabel);
        }

        private void ControlSizeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
