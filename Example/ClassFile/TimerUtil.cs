using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Example
{
    class TimerUtil : TimerUtils
    {
        private readonly System.Windows.Forms.Timer _timer;
        private readonly Action _task;
        public bool IsRunning { get; private set; }

        public TimerUtil(int intervalmilliseconds, Action task)
        {
            _task = task ?? throw new ArgumentNullException(nameof(task));
            _timer = new System.Windows.Forms.Timer { Interval = intervalmilliseconds };
            _timer.Tick += (s, e) => _task();
        }

        public void Start()
        {
            if (!IsRunning)
            {
                _timer.Start();
                IsRunning = true;
            }
        }

        public void Stop()
        {
            if (IsRunning)
            {
                _timer.Stop();
                IsRunning = false;
            }
        }

        public void Toggle()
        {
            if (IsRunning) Stop();
            else Start();
        }
    }
}
