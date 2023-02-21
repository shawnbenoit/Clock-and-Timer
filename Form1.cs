using System;
using System.Windows.Forms;

namespace Clock_and_Timer
{
	public partial class Clock : Form
	{
		public Clock()
		{
			InitializeComponent();
			Current_timer();
		}

		public void Current_timer()
		{
			int timeToCountDown;
			timer1.Start();
		}

		public int timeSpan(int currentTime)
		{
			int startTime = currentTime;
			int endTime = currentTime -= 1000;
			int seconds = startTime - endTime;
			return seconds;
		}

		public void Count_down(int duration)
		{
			if(duration == 0)
			{
				timer1.Stop();
			}
			else if(duration > 0)
			{
				duration--;
				CurrentTimeLabel.Text = duration.ToString();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Count_down();
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

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if(textBox1 != null)
			{
				int duration = int.Parse(textBox1.Text) * 60;
				timeSpan(duration);
			}
		}
	}
}
