using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class StreamReader_Write : Form
    {
        public StreamReader_Write()
        {
            InitializeComponent();
        }

        private void btnConfigSet_Click(object sender, EventArgs e)
        {            
            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(strText);
            sb.AppendLine(bChecked.ToString());
            sb.AppendLine(iNumber.ToString());

            tboxConfigData.Text = sb.ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = "";
            SFDialog.InitialDirectory = Application.StartupPath;
            SFDialog.FileName = "*.txt";
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;
                StreamWriter swSFDialog = new StreamWriter(strFilePath);
                swSFDialog.WriteLine(tboxConfigData.Text);
                swSFDialog.Close();

                File.WriteAllText(strFilePath, tboxConfigData.Text);
                
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = "";
            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.txt";
            OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            StringBuilder sb = new StringBuilder();
            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;
                StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);

                while (srOFDialog.EndOfStream == false)
                {
                    sb.AppendLine(srOFDialog.ReadLine());
                }
                tboxConfigData.Text = sb.ToString();
            }
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            tboxData.Text = strConfig[0];
            cboxData.Checked = bool.Parse(strConfig[1]);
            numData.Value = int.Parse(strConfig[2]);
        }
    }
}
