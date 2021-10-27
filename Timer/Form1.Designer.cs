
namespace Timer
{
    partial class Form1
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
            this.textBoxHoursOfTimer = new System.Windows.Forms.TextBox();
            this.textBoxMinutesOfTimer = new System.Windows.Forms.TextBox();
            this.textBoxSecondsOfTimer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTimerAdd = new System.Windows.Forms.Button();
            this.textBoxHoursOfAlarmClock = new System.Windows.Forms.TextBox();
            this.textBoxMinutesOfAlarmClock = new System.Windows.Forms.TextBox();
            this.textBoxSecondsOfAlarmClock = new System.Windows.Forms.TextBox();
            this.buttonAlarmClockAdd = new System.Windows.Forms.Button();
            this.timersAndAC = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.textBoxClosestTimer = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.textBoxRemaining = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBoxClosestAC = new System.Windows.Forms.ToolStripTextBox();
            this.textBoxACRemaining = new System.Windows.Forms.ToolStripTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonByAscending = new System.Windows.Forms.Button();
            this.buttonByDescending = new System.Windows.Forms.Button();
            this.buttonClosest = new System.Windows.Forms.Button();
            this.buttonFurthest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxShowTimers = new System.Windows.Forms.CheckBox();
            this.checkBoxShowAlarms = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHoursOfTimer
            // 
            this.textBoxHoursOfTimer.Location = new System.Drawing.Point(12, 89);
            this.textBoxHoursOfTimer.Name = "textBoxHoursOfTimer";
            this.textBoxHoursOfTimer.Size = new System.Drawing.Size(79, 22);
            this.textBoxHoursOfTimer.TabIndex = 0;
            // 
            // textBoxMinutesOfTimer
            // 
            this.textBoxMinutesOfTimer.Location = new System.Drawing.Point(97, 89);
            this.textBoxMinutesOfTimer.Name = "textBoxMinutesOfTimer";
            this.textBoxMinutesOfTimer.Size = new System.Drawing.Size(79, 22);
            this.textBoxMinutesOfTimer.TabIndex = 1;
            // 
            // textBoxSecondsOfTimer
            // 
            this.textBoxSecondsOfTimer.Location = new System.Drawing.Point(182, 89);
            this.textBoxSecondsOfTimer.Name = "textBoxSecondsOfTimer";
            this.textBoxSecondsOfTimer.Size = new System.Drawing.Size(79, 22);
            this.textBoxSecondsOfTimer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(469, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alarm Clock";
            // 
            // buttonTimerAdd
            // 
            this.buttonTimerAdd.Location = new System.Drawing.Point(267, 89);
            this.buttonTimerAdd.Name = "buttonTimerAdd";
            this.buttonTimerAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonTimerAdd.TabIndex = 5;
            this.buttonTimerAdd.Text = "Add";
            this.buttonTimerAdd.UseVisualStyleBackColor = true;
            this.buttonTimerAdd.Click += new System.EventHandler(this.buttonTimerAdd_Click);
            // 
            // textBoxHoursOfAlarmClock
            // 
            this.textBoxHoursOfAlarmClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHoursOfAlarmClock.Location = new System.Drawing.Point(430, 90);
            this.textBoxHoursOfAlarmClock.Name = "textBoxHoursOfAlarmClock";
            this.textBoxHoursOfAlarmClock.Size = new System.Drawing.Size(79, 22);
            this.textBoxHoursOfAlarmClock.TabIndex = 6;
            // 
            // textBoxMinutesOfAlarmClock
            // 
            this.textBoxMinutesOfAlarmClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinutesOfAlarmClock.Location = new System.Drawing.Point(515, 90);
            this.textBoxMinutesOfAlarmClock.Name = "textBoxMinutesOfAlarmClock";
            this.textBoxMinutesOfAlarmClock.Size = new System.Drawing.Size(79, 22);
            this.textBoxMinutesOfAlarmClock.TabIndex = 7;
            // 
            // textBoxSecondsOfAlarmClock
            // 
            this.textBoxSecondsOfAlarmClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSecondsOfAlarmClock.Location = new System.Drawing.Point(600, 90);
            this.textBoxSecondsOfAlarmClock.Name = "textBoxSecondsOfAlarmClock";
            this.textBoxSecondsOfAlarmClock.Size = new System.Drawing.Size(79, 22);
            this.textBoxSecondsOfAlarmClock.TabIndex = 8;
            // 
            // buttonAlarmClockAdd
            // 
            this.buttonAlarmClockAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlarmClockAdd.Location = new System.Drawing.Point(685, 90);
            this.buttonAlarmClockAdd.Name = "buttonAlarmClockAdd";
            this.buttonAlarmClockAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAlarmClockAdd.TabIndex = 9;
            this.buttonAlarmClockAdd.Text = "Add";
            this.buttonAlarmClockAdd.UseVisualStyleBackColor = true;
            this.buttonAlarmClockAdd.Click += new System.EventHandler(this.buttonAlarmClockAdd_Click);
            // 
            // timersAndAC
            // 
            this.timersAndAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timersAndAC.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timersAndAC.FormattingEnabled = true;
            this.timersAndAC.ItemHeight = 34;
            this.timersAndAC.Location = new System.Drawing.Point(12, 168);
            this.timersAndAC.Name = "timersAndAC";
            this.timersAndAC.Size = new System.Drawing.Size(748, 242);
            this.timersAndAC.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Seconds";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hours";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(606, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Seconds";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(330, 417);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 21);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Do not disturb";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxClosestTimer,
            this.toolStripSeparator1,
            this.textBoxRemaining,
            this.toolStripSeparator2,
            this.textBoxClosestAC,
            this.textBoxACRemaining});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // textBoxClosestTimer
            // 
            this.textBoxClosestTimer.Enabled = false;
            this.textBoxClosestTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxClosestTimer.Name = "textBoxClosestTimer";
            this.textBoxClosestTimer.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // textBoxRemaining
            // 
            this.textBoxRemaining.Enabled = false;
            this.textBoxRemaining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxRemaining.Name = "textBoxRemaining";
            this.textBoxRemaining.Size = new System.Drawing.Size(140, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // textBoxClosestAC
            // 
            this.textBoxClosestAC.Enabled = false;
            this.textBoxClosestAC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxClosestAC.Name = "textBoxClosestAC";
            this.textBoxClosestAC.Size = new System.Drawing.Size(210, 27);
            // 
            // textBoxACRemaining
            // 
            this.textBoxACRemaining.Enabled = false;
            this.textBoxACRemaining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxACRemaining.Name = "textBoxACRemaining";
            this.textBoxACRemaining.Size = new System.Drawing.Size(130, 27);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Sort:";
            // 
            // buttonByAscending
            // 
            this.buttonByAscending.Location = new System.Drawing.Point(73, 127);
            this.buttonByAscending.Name = "buttonByAscending";
            this.buttonByAscending.Size = new System.Drawing.Size(100, 27);
            this.buttonByAscending.TabIndex = 26;
            this.buttonByAscending.Text = "Ascending";
            this.buttonByAscending.UseVisualStyleBackColor = true;
            this.buttonByAscending.Click += new System.EventHandler(this.buttonByAscending_Click);
            // 
            // buttonByDescending
            // 
            this.buttonByDescending.Location = new System.Drawing.Point(179, 127);
            this.buttonByDescending.Name = "buttonByDescending";
            this.buttonByDescending.Size = new System.Drawing.Size(100, 27);
            this.buttonByDescending.TabIndex = 27;
            this.buttonByDescending.Text = "Descending";
            this.buttonByDescending.UseVisualStyleBackColor = true;
            this.buttonByDescending.Click += new System.EventHandler(this.buttonByDescending_Click);
            // 
            // buttonClosest
            // 
            this.buttonClosest.Location = new System.Drawing.Point(509, 125);
            this.buttonClosest.Name = "buttonClosest";
            this.buttonClosest.Size = new System.Drawing.Size(100, 27);
            this.buttonClosest.TabIndex = 28;
            this.buttonClosest.Text = "Closest";
            this.buttonClosest.UseVisualStyleBackColor = true;
            this.buttonClosest.Click += new System.EventHandler(this.buttonClosest_Click);
            // 
            // buttonFurthest
            // 
            this.buttonFurthest.Location = new System.Drawing.Point(615, 125);
            this.buttonFurthest.Name = "buttonFurthest";
            this.buttonFurthest.Size = new System.Drawing.Size(100, 27);
            this.buttonFurthest.TabIndex = 29;
            this.buttonFurthest.Text = "Furthest";
            this.buttonFurthest.UseVisualStyleBackColor = true;
            this.buttonFurthest.Click += new System.EventHandler(this.buttonFurthest_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Sort by:";
            // 
            // checkBoxShowTimers
            // 
            this.checkBoxShowTimers.AutoSize = true;
            this.checkBoxShowTimers.Checked = true;
            this.checkBoxShowTimers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowTimers.Location = new System.Drawing.Point(114, 417);
            this.checkBoxShowTimers.Name = "checkBoxShowTimers";
            this.checkBoxShowTimers.Size = new System.Drawing.Size(111, 21);
            this.checkBoxShowTimers.TabIndex = 31;
            this.checkBoxShowTimers.Text = "Show Timers";
            this.checkBoxShowTimers.UseVisualStyleBackColor = true;
            this.checkBoxShowTimers.CheckedChanged += new System.EventHandler(this.checkBoxShowTimers_CheckedChanged);
            // 
            // checkBoxShowAlarms
            // 
            this.checkBoxShowAlarms.AutoSize = true;
            this.checkBoxShowAlarms.Checked = true;
            this.checkBoxShowAlarms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowAlarms.Location = new System.Drawing.Point(548, 416);
            this.checkBoxShowAlarms.Name = "checkBoxShowAlarms";
            this.checkBoxShowAlarms.Size = new System.Drawing.Size(111, 21);
            this.checkBoxShowAlarms.TabIndex = 32;
            this.checkBoxShowAlarms.Text = "Show Alarms";
            this.checkBoxShowAlarms.UseVisualStyleBackColor = true;
            this.checkBoxShowAlarms.CheckedChanged += new System.EventHandler(this.checkBoxShowAlarms_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxShowAlarms);
            this.Controls.Add(this.checkBoxShowTimers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonFurthest);
            this.Controls.Add(this.buttonClosest);
            this.Controls.Add(this.buttonByDescending);
            this.Controls.Add(this.buttonByAscending);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timersAndAC);
            this.Controls.Add(this.buttonAlarmClockAdd);
            this.Controls.Add(this.textBoxSecondsOfAlarmClock);
            this.Controls.Add(this.textBoxMinutesOfAlarmClock);
            this.Controls.Add(this.textBoxHoursOfAlarmClock);
            this.Controls.Add(this.buttonTimerAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSecondsOfTimer);
            this.Controls.Add(this.textBoxMinutesOfTimer);
            this.Controls.Add(this.textBoxHoursOfTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxHoursOfTimer;
        private System.Windows.Forms.TextBox textBoxMinutesOfTimer;
        private System.Windows.Forms.TextBox textBoxSecondsOfTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTimerAdd;
        private System.Windows.Forms.TextBox textBoxHoursOfAlarmClock;
        private System.Windows.Forms.TextBox textBoxMinutesOfAlarmClock;
        private System.Windows.Forms.TextBox textBoxSecondsOfAlarmClock;
        private System.Windows.Forms.Button buttonAlarmClockAdd;
        private System.Windows.Forms.ListBox timersAndAC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox textBoxClosestTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox textBoxRemaining;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonByAscending;
        private System.Windows.Forms.Button buttonByDescending;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox textBoxClosestAC;
        private System.Windows.Forms.ToolStripTextBox textBoxACRemaining;
        private System.Windows.Forms.Button buttonClosest;
        private System.Windows.Forms.Button buttonFurthest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxShowTimers;
        private System.Windows.Forms.CheckBox checkBoxShowAlarms;
    }
}

