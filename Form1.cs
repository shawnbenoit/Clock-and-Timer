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
			dayslbl.Text = duration.ToString();
			int durationMin = end.Minute - now.Minute;
			minslbl.Text = durationMin.ToString();
			int durationSec = end.Second - now.Second;
			secslbl.Text = durationSec.ToString();
			int totalTimeLeft = (durationDay / 24 * 60 * 60) + (durationMin * 60) + (durationSec * 60);
			int daysLeft = totalTimeLeft % 24;
			int minutesLeft = (totalTimeLeft - daysLeft) % 60;
			int secondsLeft = minutesLeft % 60;
			string remaingTime = daysLeft.ToString() + ":" + minutesLeft.ToString() + ":" + secondsLeft.ToString();

			if(totalTimeLeft == 0)
			{
				timer1.Stop();
			}
			else if(totalTimeLeft > 0)
			{
				totalTimeLeft -= 1;
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
