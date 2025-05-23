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
    public partial class XmlReader_Write : Form
    {
        public XmlReader_Write()
        {
            InitializeComponent();
        }
        
        Dictionary<string, string> _dData = new Dictionary<string, string>();
        BasicSettingData basic = new BasicSettingData();

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

            _dData.Clear();
            basic.TextData = strText;
            basic.CBoxData = bChecked.ToString();
            basic.NumberData = iNumber.ToString();

            _dData.Add(basic.TextData, basic.TextData);
            _dData.Add(basic.CBoxData, basic.CBoxData);
            _dData.Add(basic.NumberData, basic.NumberData);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = "";
            SFDialog.InitialDirectory = Application.StartupPath;
            SFDialog.FileName = "*.xml";
            SFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

           
            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;

                var manager = new XmlDataManager<BasicSettingData>();

                var basic = new BasicSettingData
                {
                    TextData = tboxData.Text,
                    CBoxData = cboxData.Checked ? "True" : "False",
                    NumberData = ((int)numData.Value).ToString()
                };
                manager.Write(strFilePath, basic);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new XmlDataManager<BasicSettingData>();

            string strFilePath = "";
            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.xml";
            OFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            StringBuilder sb = new StringBuilder();
            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;
                var loaded = manager.Read(strFilePath);
                tboxConfigData.Text = $"{loaded.TextData}\r\n{loaded.CBoxData}\r\n{loaded.NumberData}";
            }
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            string checkNumValue = numData.Value.ToString();
            tboxData.Text = _dData[basic.TextData];
            cboxData.Checked= bool.Parse(_dData[basic.CBoxData]);
            
            numData.Value= int.Parse(_dData[basic.NumberData]);
            numData.Refresh();
        }
    }
}
