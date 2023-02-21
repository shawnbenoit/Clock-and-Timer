using System;
using System.Windows.Forms;

namespace Clock_and_Timer
{
	public partial class Clock : Form
	{
		public Clock()
		{
			InitializeComponent();
			timer1.Start();
		}

		public int timeSpan(int currentTime)
		{
			int startTime = currentTime;
			int endTime = currentTime -= 1000;
			int seconds = startTime - endTime;
			return seconds;
		}

		DateTime now = DateTime.Now;

		public void Count_down(DateTime now)
		{
			DateTime nowTime = now;
			DateTime end = new DateTime(2023, 02, 22, 15, 00, 00);
			TimeSpan duration = end - nowTime;

			int durationDay = end.Day - now.Day;
			int durationMin = end.Minute - now.Minute;
			int durationSec = end.Second - now.Second;
            int totalTimeRemaining = durationSec + (durationMin * 60) + (durationDay * 60 * 60);

            string remaingTime = durationDay + ":" + durationMin + ":" + durationSec;

            secslbl.Text = durationSec.ToString();
            minslbl.Text = durationMin.ToString();
            dayslbl.Text = durationDay.ToString();

            if (totalTimeRemaining == 0)
			{
				timer1.Stop();
			}
			else if(totalTimeRemaining > 0)
			{
                totalTimeRemaining -= 1;
				CurrentTimeLabel.Text = remaingTime;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Count_down(now);
		}

		private void fullScreenButton_Click(object sender, EventArgs e)
		{
			if(Clock.ActiveForm.WindowState == FormWindowState.Maximized)
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
