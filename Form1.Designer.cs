namespace Clock_and_Timer
{
    partial class Clock
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
            if (disposing && (components != null))
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
			this.CurrentTimeLabel = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.exitButton = new System.Windows.Forms.Button();
			this.fullScreenButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.musicfolder = new System.Windows.Forms.Button();
			this.picturefolder = new System.Windows.Forms.Button();
			this.picturetitlelabel = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.datetimepicker = new System.Windows.Forms.Button();
			this.playbutton = new System.Windows.Forms.Button();
			this.pausebutton = new System.Windows.Forms.Button();
			this.randombutton = new System.Windows.Forms.Button();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// CurrentTimeLabel
			// 
			this.CurrentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CurrentTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.CurrentTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CurrentTimeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CurrentTimeLabel.ForeColor = System.Drawing.Color.White;
			this.CurrentTimeLabel.Location = new System.Drawing.Point(0, 457);
			this.CurrentTimeLabel.Margin = new System.Windows.Forms.Padding(51);
			this.CurrentTimeLabel.Name = "CurrentTimeLabel";
			this.CurrentTimeLabel.Size = new System.Drawing.Size(853, 117);
			this.CurrentTimeLabel.TabIndex = 0;
			this.CurrentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CurrentTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
			this.CurrentTimeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
			this.CurrentTimeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.exitButton.FlatAppearance.BorderSize = 0;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.Color.DimGray;
			this.exitButton.Location = new System.Drawing.Point(712, 0);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(55, 25);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
			this.exitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
			this.exitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
			// 
			// fullScreenButton
			// 
			this.fullScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fullScreenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fullScreenButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.fullScreenButton.FlatAppearance.BorderSize = 0;
			this.fullScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fullScreenButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fullScreenButton.ForeColor = System.Drawing.Color.DimGray;
			this.fullScreenButton.Location = new System.Drawing.Point(773, 0);
			this.fullScreenButton.Name = "fullScreenButton";
			this.fullScreenButton.Size = new System.Drawing.Size(80, 25);
			this.fullScreenButton.TabIndex = 2;
			this.fullScreenButton.Text = "Fullscreen";
			this.fullScreenButton.UseVisualStyleBackColor = true;
			this.fullScreenButton.Click += new System.EventHandler(this.fullScreenButton_Click);
			this.fullScreenButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
			this.fullScreenButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
			this.fullScreenButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.pictureBox1.ErrorImage = global::Clock_and_Timer.Properties.Resources.Tellepsen_sharepoint_logo;
			this.pictureBox1.Image = global::Clock_and_Timer.Properties.Resources.Tellepsen_sharepoint_logo;
			this.pictureBox1.Location = new System.Drawing.Point(97, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(657, 347);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
			// 
			// titleLabel
			// 
			this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.Color.White;
			this.titleLabel.Location = new System.Drawing.Point(0, 406);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(853, 52);
			this.titleLabel.TabIndex = 4;
			this.titleLabel.Text = "Event begins in: ";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
			this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
			this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
			// 
			// musicfolder
			// 
			this.musicfolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.musicfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.musicfolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.musicfolder.FlatAppearance.BorderSize = 0;
			this.musicfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.musicfolder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.musicfolder.ForeColor = System.Drawing.Color.DimGray;
			this.musicfolder.Location = new System.Drawing.Point(167, 0);
			this.musicfolder.Name = "musicfolder";
			this.musicfolder.Size = new System.Drawing.Size(55, 25);
			this.musicfolder.TabIndex = 5;
			this.musicfolder.Text = "Music";
			this.musicfolder.UseVisualStyleBackColor = false;
			this.musicfolder.Click += new System.EventHandler(this.musicfolder_Click);
			// 
			// picturefolder
			// 
			this.picturefolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.picturefolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.picturefolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.picturefolder.FlatAppearance.BorderSize = 0;
			this.picturefolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.picturefolder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picturefolder.ForeColor = System.Drawing.Color.DimGray;
			this.picturefolder.Location = new System.Drawing.Point(106, 0);
			this.picturefolder.Name = "picturefolder";
			this.picturefolder.Size = new System.Drawing.Size(55, 25);
			this.picturefolder.TabIndex = 6;
			this.picturefolder.Text = "Pictures";
			this.picturefolder.UseVisualStyleBackColor = false;
			this.picturefolder.Click += new System.EventHandler(this.picturefolder_Click);
			// 
			// picturetitlelabel
			// 
			this.picturetitlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturetitlelabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picturetitlelabel.ForeColor = System.Drawing.Color.White;
			this.picturetitlelabel.Location = new System.Drawing.Point(0, 371);
			this.picturetitlelabel.Margin = new System.Windows.Forms.Padding(0);
			this.picturetitlelabel.Name = "picturetitlelabel";
			this.picturetitlelabel.Size = new System.Drawing.Size(852, 35);
			this.picturetitlelabel.TabIndex = 7;
			this.picturetitlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.picturetitlelabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
			this.picturetitlelabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
			this.picturetitlelabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.pictureBox2.ErrorImage = global::Clock_and_Timer.Properties.Resources.Tellepsen_sharepoint_logo;
			this.pictureBox2.Image = global::Clock_and_Timer.Properties.Resources.Tellepsen_sharepoint_logo;
			this.pictureBox2.Location = new System.Drawing.Point(0, 86);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(427, 215);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.pictureBox3.ErrorImage = global::Clock_and_Timer.Properties.Resources.Tellepsen_sharepoint_logo;
			this.pictureBox3.Image = global::Clock_and_Timer.Properties.Resources.Tellepsen_sharepoint_logo;
			this.pictureBox3.Location = new System.Drawing.Point(425, 86);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(427, 215);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			// 
			// datetimepicker
			// 
			this.datetimepicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.datetimepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datetimepicker.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.datetimepicker.FlatAppearance.BorderSize = 0;
			this.datetimepicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.datetimepicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datetimepicker.ForeColor = System.Drawing.Color.DimGray;
			this.datetimepicker.Location = new System.Drawing.Point(0, 0);
			this.datetimepicker.Name = "datetimepicker";
			this.datetimepicker.Size = new System.Drawing.Size(100, 25);
			this.datetimepicker.TabIndex = 10;
			this.datetimepicker.Text = "Date and Time";
			this.datetimepicker.UseVisualStyleBackColor = false;
			this.datetimepicker.Click += new System.EventHandler(this.datetimepicker_Click);
			// 
			// playbutton
			// 
			this.playbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.playbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.playbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.playbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.playbutton.FlatAppearance.BorderSize = 0;
			this.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.playbutton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playbutton.ForeColor = System.Drawing.Color.DimGray;
			this.playbutton.Location = new System.Drawing.Point(339, 0);
			this.playbutton.Name = "playbutton";
			this.playbutton.Size = new System.Drawing.Size(55, 25);
			this.playbutton.TabIndex = 11;
			this.playbutton.Text = "Play";
			this.playbutton.UseVisualStyleBackColor = false;
			// 
			// pausebutton
			// 
			this.pausebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pausebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pausebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.pausebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.pausebutton.FlatAppearance.BorderSize = 0;
			this.pausebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pausebutton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pausebutton.ForeColor = System.Drawing.Color.DimGray;
			this.pausebutton.Location = new System.Drawing.Point(400, 0);
			this.pausebutton.Name = "pausebutton";
			this.pausebutton.Size = new System.Drawing.Size(55, 25);
			this.pausebutton.TabIndex = 11;
			this.pausebutton.Text = "Pause";
			this.pausebutton.UseVisualStyleBackColor = false;
			// 
			// randombutton
			// 
			this.randombutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.randombutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.randombutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.randombutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.randombutton.FlatAppearance.BorderSize = 0;
			this.randombutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.randombutton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.randombutton.ForeColor = System.Drawing.Color.DimGray;
			this.randombutton.Location = new System.Drawing.Point(461, 0);
			this.randombutton.Name = "randombutton";
			this.randombutton.Size = new System.Drawing.Size(55, 25);
			this.randombutton.TabIndex = 12;
			this.randombutton.Text = "Random";
			this.randombutton.UseVisualStyleBackColor = false;
			// 
			// datePicker
			// 
			this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datePicker.Location = new System.Drawing.Point(1, 554);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(53, 20);
			this.datePicker.TabIndex = 13;
			this.datePicker.Visible = false;
			// 
			// timePicker
			// 
			this.timePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timePicker.Location = new System.Drawing.Point(60, 554);
			this.timePicker.Name = "timePicker";
			this.timePicker.Size = new System.Drawing.Size(57, 20);
			this.timePicker.TabIndex = 14;
			this.timePicker.Visible = false;
			// 
			// Clock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(853, 574);
			this.Controls.Add(this.timePicker);
			this.Controls.Add(this.datePicker);
			this.Controls.Add(this.randombutton);
			this.Controls.Add(this.pausebutton);
			this.Controls.Add(this.playbutton);
			this.Controls.Add(this.datetimepicker);
			this.Controls.Add(this.picturetitlelabel);
			this.Controls.Add(this.picturefolder);
			this.Controls.Add(this.musicfolder);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.fullScreenButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.CurrentTimeLabel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(51, 46, 51, 46);
			this.Name = "Clock";
			this.Text = "Timer";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button fullScreenButton;
        private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label CurrentTimeLabel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Button musicfolder;
		private System.Windows.Forms.Button picturefolder;
		private System.Windows.Forms.Label picturetitlelabel;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button datetimepicker;
		private System.Windows.Forms.Button playbutton;
		private System.Windows.Forms.Button pausebutton;
		private System.Windows.Forms.Button randombutton;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.DateTimePicker timePicker;
	}
}

