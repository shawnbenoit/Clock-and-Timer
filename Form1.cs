using System;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Dialogs;

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
			DateTime endTime = new DateTime(2023, 02, 22, 15, 05, 00);

			TimeSpan T = endTime - nowTime;

			string remainingTime = string.Format("{0:hh\\:mm\\:ss}", T);

			if(T.Hours == 0 && T.Minutes == 0 && T.Seconds == 0)
			{
				timer1.Stop();
				CurrentTimeLabel.Text = "It is 3:00 PM.";
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

		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;

		private void _MouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}

		private void _MouseMove(object sender, MouseEventArgs e)
		{
			if(dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}

		private void _MouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void SelectFolder(string path)
		{
			string dirpath = path;
			CommonOpenFileDialog dialog = new CommonOpenFileDialog();

			if(path == null || path == "")
			{
				dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			}
			else if(path == "MyPictures")
			{
				dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			}
			else if(path == "MyMusic")
			{
				dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
			}

			dialog.IsFolderPicker = true;
			if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				// call respective function here
				MessageBox.Show("You selected: " + dialog.FileName);
			}
		}

		private void musicfolder_Click(object sender, EventArgs e)
		{
			SelectFolder("MyMusic");
		}

		private void picturefolder_Click(object sender, EventArgs e)
		{
			SelectFolder("MyPictures");
		}
	}
}
