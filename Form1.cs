﻿using System;
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

		public void Count_down(DateTime now)
		{
			DateTime nowTime = now;
			DateTime endTime = new DateTime(2023, 02, 22, 15, 00, 00);

			TimeSpan T = endTime - nowTime;

			string remainingTime = string.Format("{0:hh\\:mm\\:ss}", T);

			if(T.Hours == 0 && T.Minutes == 0 && T.Seconds == 0)
			{
				timer1.Stop();
				CurrentTimeLabel.Text = "Time's Up!";
			}
			else
			{
				CurrentTimeLabel.Text = remainingTime;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
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
