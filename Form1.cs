using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time2;

namespace Clock_and_Timer
{
    public partial class Clock : Form
    {

        CTime2 currentTime = new CTime2();

        public Clock()
        {
            InitializeComponent();
            CurrentTime();
        }

        

        public CTime2 CurrentTime()
        {
            DateTime dateTime = DateTime.Now;
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;
            int second = dateTime.Second;

            currentTime.Hour = hour;
            currentTime.Minute = minute;
            currentTime.Second = second;

            currentTime = new CTime2(currentTime.Hour, currentTime.Minute, currentTime.Second);
            
            timer1.Enabled = true;

            return currentTime;
        }

        public void updateTime()
        {
            currentTime.addTime(0, 0, 1);
            CurrentTimeLabel.Text = $"{currentTime.ToString()}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTime();
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
