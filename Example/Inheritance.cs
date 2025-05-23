using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.Windows.Forms;

namespace Example
{
    public partial class Inheritance : Form
    {
        COneCycle _cOC;
        CCycle _cC;
        CCar _cCar;
        public Inheritance()
        {
            InitializeComponent();
        }
        private void Inheritance_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
            _cC = new CCycle("자전거");
            _cCar = new CCar("자동차");
        }

   


        private void fOneCycleDraw()
        {
            lblName.Text = _cOC.strName;
            Graphics g = pMain.CreateGraphics();
            Pen p = _cOC.FpenInfo();
            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);
        }

        private void fCycleDraw()
        {
            lblName.Text = _cC.strName;
            Graphics g = pMain.CreateGraphics();
            Pen p = _cC.FpenInfo();
            g.DrawRectangle(p, _cC._rtSquare1);
            g.DrawEllipse(p, _cC._rtCircle1);
            g.DrawEllipse(p, _cC._rtCircle2);
        }

        private void fCarDraw()
        {
            lblName.Text = _cCar.strName;
            Graphics g = pMain.CreateGraphics();
            Pen p = _cCar.FpenInfo();
            g.DrawRectangle(p, _cCar._rtSquare1);
            g.DrawRectangle(p, _cCar._rtSquare2);
            g.DrawEllipse(p, _cCar._rtCircle1);
            g.DrawEllipse(p, _cCar._rtCircle2);
        }

        private void fClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }
        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fOneCycleDraw();
        }

       

        private void btnCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCycleDraw();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCarDraw();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            fClearPanel();
            switch (lblName.Text)
            {
                case "외발 자전거":
                    _cOC.fMove(5);
                    fOneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(5);
                    fCycleDraw();
                    break;
                case "자동차":
                    _cCar.fMove(5);
                    fCarDraw();
                    break;                
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            fClearPanel();
            switch (lblName.Text)
            {
                case "외발 자전거":
                    _cOC.fMove(-5);
                    fOneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(-5);
                    fCycleDraw();
                    break;
                case "자동차":
                    _cCar.fMove(-5);
                    fCarDraw();
                    break;
            }            
        }

      
    }
}