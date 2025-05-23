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
    public partial class StructerClass : Form
    {
        Queue<int> _queue = new Queue<int>(6);
        Stack<int> _stack = new Stack<int>(6);
        private TimerUtil _autoDataTask;
        public StructerClass()
        {
            InitializeComponent();
            _autoDataTask = new TimerUtil(2000, () => btnDataOut_Click(null, null));   
        }

        private void btnDataIn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int iData = random.Next(1, 101);

            //queue에 Data In.
            if (_queue.Count < 6)
            {
                _queue.Enqueue(iData);
                fQueueDataDisplay();
            }
            if (_stack.Count < 6)
            {
                _stack.Push(iData);
                fStackDataDisplay();
            }
        }

        private void fQueueDataDisplay()
        {
            int[] iArray = _queue.ToArray();
            Array.Resize(ref iArray, 6);
            lblQueue1.Text = iArray[0] == 0 ? "" : iArray[0].ToString();
            lblQueue2.Text = iArray[1] == 0 ? "" : iArray[1].ToString();
            lblQueue3.Text = iArray[2] == 0 ? "" : iArray[2].ToString();
            lblQueue4.Text = iArray[3] == 0 ? "" : iArray[3].ToString();
            lblQueue5.Text = iArray[4] == 0 ? "" : iArray[4].ToString();
            lblQueue6.Text = iArray[5] == 0 ? "" : iArray[5].ToString();
        }

        private void fStackDataDisplay()
        {
            int[] iArray = _stack.ToArray();
            Array.Resize(ref iArray, 6);
            lblStack1.Text = iArray[0] == 0 ? "" : iArray[0].ToString();
            lblStack2.Text = iArray[1] == 0 ? "" : iArray[1].ToString();
            lblStack3.Text = iArray[2] == 0 ? "" : iArray[2].ToString();
            lblStack4.Text = iArray[3] == 0 ? "" : iArray[3].ToString();
            lblStack5.Text = iArray[4] == 0 ? "" : iArray[4].ToString();
            lblStack6.Text = iArray[5] == 0 ? "" : iArray[5].ToString();
        }

        private void btnDataOut_Click(object sender, EventArgs e)
        {
            //queue에 Data In.
            if (_queue.Count > 0)
            {
                _queue.Dequeue();
                fQueueDataDisplay();
            }
            if (_stack.Count > 0)
            {
                _stack.Pop();
                fStackDataDisplay();
            }
        }

        private void btnDataAuto_Click(object sender, EventArgs e)
        {
            _autoDataTask.Toggle();
        }

    }
}