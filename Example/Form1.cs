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
    public partial class Form1 : Form
    {
        private readonly Dictionary<Button, Type> _formMap;

        public Form1()
        {
            InitializeComponent();

            _formMap = new Dictionary<Button, Type>
            {
                { button2, typeof(Study_string) },
                { button3, typeof(DataType) },
                { button4, typeof(Method) },
                { button5, typeof(Sturct_Class) },
                { button6, typeof(Inheritance) },
                { button7, typeof(EnumClass) },
                { button8, typeof(StreamReader_Write) },
                { button9, typeof(XmlReader_Write) },
                { button10, typeof(Simple_Clicker) },
                { button11, typeof(StructerClass) },
                { button12, typeof(ListClass) },
            };

            foreach (var pair in _formMap)
            {
                pair.Key.Click += OnButtonClick;
            }
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            if (sender is Button btn && _formMap.TryGetValue(btn, out var formType))
            {
                var formInstance = (Form)Activator.CreateInstance(formType);
                formInstance.Show();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            endUserLblChk_1.Controls.Clear();
            UC_endUserLbl_Check ucFrm = new UC_endUserLbl_Check();
            ucFrm.LOT_ID = "LOT_ID";
            ucFrm.viewPanel = endUserLblChk_1;
            ucFrm.ResultForward += new UC_endUserLbl_Check.delResultEvent(this.FuncTest);
            this.endUserLblChk_1.Controls.Add(ucFrm);
            endUserLblChk_1.Visible = true;

        }

        private void FuncTest(ResultForwardArgs result)
        {
            test.Text = "DELEGATE";
        }
    }
}