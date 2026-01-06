using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Study._32강의
{
    public partial class TitlePractice : Form
    {
        public TitlePractice()
        {
            InitializeComponent();
        }

        private void TitlePractice_Load(object sender, EventArgs e)
        {
            Version oVesrion = Assembly.GetEntryAssembly().GetName().Version;

            this.Text = oVesrion.ToString();

        }
    }
}
