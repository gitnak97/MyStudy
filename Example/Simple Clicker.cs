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
    public partial class Simple_Clicker : Form
    {
        private double iTick = 0;
        private double iTotal = 0;

        private int i1Add = 1;
        private int i1Level = 1;

        private int i3Add = 0;
        private int i3Level = 0;

        private int i50Add = 0;
        private int i50Level = 0;

        string strPath = Application.StartupPath + "\\Save.xml";

        XmlDataManager<ExtendedSettingData> manager = new XmlDataManager<ExtendedSettingData>();

        private TimerUtil _autoDataTask;

        public Simple_Clicker()
        {
            InitializeComponent();
            _autoDataTask = new TimerUtil(100, TimerEvent);
        }

        private void Simple_Clicker_Load(object sender, EventArgs e)
        {
            if (File.Exists(strPath))
            {
                var loaded = manager.Read(strPath);

                iTick = double.Parse(loaded.Tick);
                iTotal = double.Parse(loaded.Total);
                i1Level = int.Parse(loaded.Level1);
                i3Level = int.Parse(loaded.Level3);
                i50Level = int.Parse(loaded.Level50);
            }
            _autoDataTask.Toggle();
        }


        private void Simple_Clicker_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {

            var basic = new ExtendedSettingData
            {
                Tick = iTick.ToString(),
                Total = iTotal.ToString(),
                Level1 = i1Level.ToString(),
                Level3 = i3Level.ToString(),
                Level50 = i50Level.ToString(),
            };

            manager.Write(strPath, basic);   
        }

       
        private void TimerEvent()
        {
            iTick = i1Add + i3Add + i50Add;
            iTotal += iTick;
            lblTickerPoint.Text = string.Format("{0} (1:{1}), (3:{2}), (50:{3})", iTick.ToString(), i1Level.ToString(), i3Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();
        }


        private void btn1Add_Click(object sender, EventArgs e)
        {
            Button obtn = (Button)sender;
            switch (obtn.Name)
            {
                case "btn1Add":
                    i1Level++;
                    i1Add = 1 * i1Level;
                    break;
                case "btn3Add":
                    i3Level++;
                    i3Add = 3 * i3Level;
                    break;
                case "btn50Add":
                    i50Level++;
                    i50Add = 50 * i50Level;
                    break;
            }
        }
    }
    
}
