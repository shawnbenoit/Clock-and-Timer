namespace Clock_and_Timer
{
	partial class dateandtime
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.setdateandtime = new System.Windows.Forms.Button();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// setdateandtime
			// 
			this.setdateandtime.BackColor = System.Drawing.Color.LightSlateGray;
			this.setdateandtime.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.setdateandtime.FlatAppearance.BorderSize = 0;
			this.setdateandtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setdateandtime.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.setdateandtime.Location = new System.Drawing.Point(0, 157);
			this.setdateandtime.Name = "setdateandtime";
			this.setdateandtime.Size = new System.Drawing.Size(359, 32);
			this.setdateandtime.TabIndex = 0;
			this.setdateandtime.Text = "Okay";
			this.setdateandtime.UseVisualStyleBackColor = false;
			this.setdateandtime.Click += new System.EventHandler(this.setdateandtime_Click);
			// 
			// timePicker
			// 
			this.timePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timePicker.Location = new System.Drawing.Point(237, 12);
			this.timePicker.Name = "timePicker";
			this.timePicker.Size = new System.Drawing.Size(107, 20);
			this.timePicker.TabIndex = 16;
			this.timePicker.Visible = false;
			this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
			// 
			// datePicker
			// 
			this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datePicker.Location = new System.Drawing.Point(12, 12);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(219, 20);
			this.datePicker.TabIndex = 15;
			this.datePicker.Visible = false;
			this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
			// 
			// dateandtime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(359, 189);
			this.Controls.Add(this.timePicker);
			this.Controls.Add(this.datePicker);
			this.Controls.Add(this.setdateandtime);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "dateandtime";
			this.Text = "dateandtime";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button setdateandtime;
		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.DateTimePicker datePicker;
	}
}