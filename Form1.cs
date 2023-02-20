using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clock_and_Timer
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
            current_timer();
        }

        private int duration = 30;

        public DateTime current_timer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick -= new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();
        }

        public void count_down()
        {
            if (duration == 0)
            {
                timer1.Stop();
            }
            else if (duration > 0)
            {
                duration--;
                CurrentTimeLabel.Text = duration.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count_down();
        }


        private void fullScreenButton_Click(object sender, EventArgs e)
        {
            if (Clock.ActiveForm.WindowState == FormWindowState.Maximized)
            {
                fullScreenButton.Text = "Fullscreen";
                Clock.ActiveForm.FormBorderStyle = FormBorderStyle.Sizable;
                Clock.ActiveForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                fullScreenButton.Text = "Restore";
                Clock.ActiveForm.FormBorderStyle = FormBorderStyle.None;
                Clock.ActiveForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
