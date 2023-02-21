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
			this.CurrentTimeLabel = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.exitButton = new System.Windows.Forms.Button();
			this.fullScreenButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.EnterTimeLabel = new System.Windows.Forms.Button();
			this.SelectMusicFolder = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// CurrentTimeLabel
			// 
			this.CurrentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CurrentTimeLabel.AutoSize = true;
			this.CurrentTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.CurrentTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CurrentTimeLabel.Font = new System.Drawing.Font("Arial", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CurrentTimeLabel.ForeColor = System.Drawing.Color.White;
			this.CurrentTimeLabel.Location = new System.Drawing.Point(174, 386);
			this.CurrentTimeLabel.Margin = new System.Windows.Forms.Padding(51);
			this.CurrentTimeLabel.Name = "CurrentTimeLabel";
			this.CurrentTimeLabel.Size = new System.Drawing.Size(597, 153);
			this.CurrentTimeLabel.TabIndex = 0;
			this.CurrentTimeLabel.Text = "00:00:00";
			this.CurrentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.exitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.exitButton.FlatAppearance.BorderSize = 0;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.Color.DimGray;
			this.exitButton.Location = new System.Drawing.Point(0, 549);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(933, 25);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// fullScreenButton
			// 
			this.fullScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullScreenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fullScreenButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.fullScreenButton.FlatAppearance.BorderSize = 0;
			this.fullScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fullScreenButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fullScreenButton.ForeColor = System.Drawing.Color.DimGray;
			this.fullScreenButton.Location = new System.Drawing.Point(445, 0);
			this.fullScreenButton.Name = "fullScreenButton";
			this.fullScreenButton.Size = new System.Drawing.Size(488, 29);
			this.fullScreenButton.TabIndex = 2;
			this.fullScreenButton.Text = "Fullscreen";
			this.fullScreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.fullScreenButton.UseVisualStyleBackColor = true;
			this.fullScreenButton.Click += new System.EventHandler(this.fullScreenButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.pictureBox1.ErrorImage = global::Clock_and_Timer.Properties.Resources.Tellepsen_sharepoint_logo;
			this.pictureBox1.Image = global::Clock_and_Timer.Properties.Resources.Tellepsen_sharepoint_logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(933, 357);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// EnterTimeLabel
			// 
			this.EnterTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EnterTimeLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.EnterTimeLabel.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.EnterTimeLabel.FlatAppearance.BorderSize = 0;
			this.EnterTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EnterTimeLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EnterTimeLabel.ForeColor = System.Drawing.Color.DimGray;
			this.EnterTimeLabel.Location = new System.Drawing.Point(0, 0);
			this.EnterTimeLabel.Name = "EnterTimeLabel";
			this.EnterTimeLabel.Size = new System.Drawing.Size(67, 29);
			this.EnterTimeLabel.TabIndex = 4;
			this.EnterTimeLabel.Text = "Enter time";
			this.EnterTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.EnterTimeLabel.UseVisualStyleBackColor = true;
			// 
			// SelectMusicFolder
			// 
			this.SelectMusicFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SelectMusicFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SelectMusicFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.SelectMusicFolder.FlatAppearance.BorderSize = 0;
			this.SelectMusicFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SelectMusicFolder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectMusicFolder.ForeColor = System.Drawing.Color.DimGray;
			this.SelectMusicFolder.Location = new System.Drawing.Point(173, 0);
			this.SelectMusicFolder.Name = "SelectMusicFolder";
			this.SelectMusicFolder.Size = new System.Drawing.Size(134, 29);
			this.SelectMusicFolder.TabIndex = 5;
			this.SelectMusicFolder.Text = "Select Music";
			this.SelectMusicFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SelectMusicFolder.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(70, 6);
			this.textBox1.Margin = new System.Windows.Forms.Padding(0);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 19);
			this.textBox1.TabIndex = 6;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Clock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(933, 574);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.SelectMusicFolder);
			this.Controls.Add(this.EnterTimeLabel);
			this.Controls.Add(this.fullScreenButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.CurrentTimeLabel);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.Highlight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(51, 46, 51, 46);
			this.Name = "Clock";
			this.Text = "ClockandTimer";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button fullScreenButton;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button EnterTimeLabel;
		private System.Windows.Forms.Button SelectMusicFolder;
		private System.Windows.Forms.TextBox textBox1;
	}
}

