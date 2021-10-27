using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Timer
{
    public partial class Form1 : Form
    {
        private SoundPlayer sound = new SoundPlayer("sound.wav");
        
        private List<int> timers = new List<int>();
        private List<int> alarmClocks = new List<int>();
        private bool isMuted = false, showTimers = true, showAlarms = true;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private bool checkString(string str)
        {
            if (str == "") return false;
            for (int i = 0; i < str.Length; ++i)
                if (str[i] < 48 || str[i] > 57) return false;
            return true;

        }
        private bool checkTime(int h, int m, int s)
        {
            if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59) return false;
            else return true;
        }

        private string secondsToTimeString(int time)
        {
            int hours = (time - (time % (60 * 60))) / (60 * 60);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }

        private int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(showTimers)
                if (timers.Count > 0)
                {
                    int fastestToGoOff = 0, minValue = int.MaxValue;
                    for (int i = 0; i < timers.Count; ++i)
                    {
                        if (timers[i] < minValue)
                        {
                            minValue = timers[i];
                            fastestToGoOff = i;
                        }
                    }
                    timersAndAC.Items[0] = ("Timer " + (fastestToGoOff + 1) + " is closest to go off\n");
                    textBoxClosestTimer.Text = ("Closest timer is in: " + secondsToTimeString(timers[fastestToGoOff] - 1));
                }
                else textBoxClosestTimer.Text = ("No active timers");
            DateTime curDate = DateTime.Now;
            int curDateSeconds = 3600 * curDate.Hour + 60 * curDate.Minute + curDate.Second;
            if(showAlarms)
                if (alarmClocks.Count > 0)
                {
                    int fastestToGoOff = 0, minValue = int.MaxValue;
                    for (int i = 0; i < alarmClocks.Count; ++i)
                    {
                        int setDateSeconds = alarmClocks[i];
                        if (alarmClocks[i] < curDate.Hour * 3600 + curDate.Minute * 60 + curDate.Second) setDateSeconds += 24 * 3600;
                        int dif = Math.Abs(curDateSeconds - setDateSeconds);
                        if (dif < minValue)
                        {
                            minValue = dif;
                            fastestToGoOff = i;
                        }
                    }
                    textBoxClosestAC.Text = ("Closest ac is at: " + secondsToTimeString(alarmClocks[fastestToGoOff]));
                }
                else textBoxClosestAC.Text = ("No active alarm clocks");
            textBoxRemaining.Text = ("Active timers: " + timers.Count);
            textBoxACRemaining.Text = ("Active A.C.: " + alarmClocks.Count);
            for (int i = 0; i < max(timers.Count, alarmClocks.Count); ++i)
            {
                if(showTimers)
                    if (i < timers.Count)
                    {
                        if (timers[i] == 0)
                        {
                            timersAndAC.Items.RemoveAt(i + 1);
                            timers.RemoveAt(i);
                            if (timers.Count == 0) timersAndAC.Items.RemoveAt(0);
                            if (!isMuted) sound.Play();
                            MessageBox.Show("Timer " + (i + 1) + " has just gone off", "Time's up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!isMuted) sound.Stop();
                            --i;
                            continue;
                        
                        }
                        else
                        {
                            --timers[i];
                            timersAndAC.Items[i + 1] = ("Timer " + (i + 1) + ": " + secondsToTimeString(timers[i]));
                        }
                    }
                if(showAlarms)
                    if(i < alarmClocks.Count)
                    {
                        int dif = Math.Abs(curDateSeconds - alarmClocks[i]);
                        if (dif < 2)
                        {
                            timersAndAC.Items.RemoveAt(timers.Count * Convert.ToInt32(showTimers) + i + Convert.ToInt32(timers.Count > 0));
                            alarmClocks.RemoveAt(i);
                            if (!isMuted) sound.Play();
                            MessageBox.Show("Alarm clock " + (i + 1) + " has just gone off", "Time has come", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!isMuted) sound.Stop();
                        }
                        else timersAndAC.Items[timers.Count * Convert.ToInt32(showTimers) + i + Convert.ToInt32(timers.Count > 0) * Convert.ToInt32(showTimers)] = ("Alarm clock " + (i + 1) + " is set for: " + secondsToTimeString(alarmClocks[i]));
                    }
            }
        }

        private void buttonTimerAdd_Click(object sender, EventArgs e)
        {
            if (!checkString(textBoxHoursOfTimer.Text) || !checkString(textBoxMinutesOfTimer.Text) || !checkString(textBoxSecondsOfTimer.Text) || !checkTime(Convert.ToInt32(textBoxHoursOfTimer.Text), Convert.ToInt32(textBoxMinutesOfTimer.Text), Convert.ToInt32(textBoxSecondsOfTimer.Text)))
                MessageBox.Show("Wrong time input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int tmpSeconds = 3600 * Convert.ToInt32(textBoxHoursOfTimer.Text) + 60 * Convert.ToInt32(textBoxMinutesOfTimer.Text) + Convert.ToInt32(textBoxSecondsOfTimer.Text);
                textBoxHoursOfTimer.Text = textBoxMinutesOfTimer.Text = textBoxSecondsOfTimer.Text = "";
                if(timers.Count == 0 && showTimers) timersAndAC.Items.Insert(0, "Timer " + 1 + " is closest to go off\n");
                if(showTimers) timersAndAC.Items.Insert(timers.Count + 1, "Timer " + (timers.Count + 1) + ": " + secondsToTimeString(tmpSeconds));
                timers.Add(tmpSeconds);
            }
        }

        private void buttonAlarmClockAdd_Click(object sender, EventArgs e)
        {
            if (!checkString(textBoxHoursOfAlarmClock.Text) || !checkString(textBoxMinutesOfAlarmClock.Text) || !checkString(textBoxSecondsOfAlarmClock.Text) || !checkTime(Convert.ToInt32(textBoxHoursOfAlarmClock.Text), Convert.ToInt32(textBoxMinutesOfAlarmClock.Text), Convert.ToInt32(textBoxSecondsOfAlarmClock.Text)))
                MessageBox.Show("Wrong time input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int tmpSeconds = 3600 * Convert.ToInt32(textBoxHoursOfAlarmClock.Text) + 60 * Convert.ToInt32(textBoxMinutesOfAlarmClock.Text) + Convert.ToInt32(textBoxSecondsOfAlarmClock.Text);
                textBoxHoursOfAlarmClock.Text = textBoxMinutesOfAlarmClock.Text = textBoxSecondsOfAlarmClock.Text = "";
                if(showAlarms) timersAndAC.Items.Insert(timers.Count * Convert.ToInt32(showTimers) + alarmClocks.Count + Convert.ToInt32(showTimers) * Convert.ToInt32(timers.Count > 0), "Alarm clock " + (alarmClocks.Count + 1) + " is set for: " + secondsToTimeString(tmpSeconds));
                alarmClocks.Add(tmpSeconds);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) isMuted = true;
            else isMuted = false;
        }

        private void buttonByAscending_Click(object sender, EventArgs e)
        {
            timers.Sort();
        }

        private void buttonByDescending_Click(object sender, EventArgs e)
        {
            timers.Sort();
            timers.Reverse();
        }

        private void sortAlarms()
        {
            DateTime curDate = DateTime.Now;
            int curDateSeconds = 3600 * curDate.Hour + 60 * curDate.Minute + curDate.Second;
            for (int i = 0; i < alarmClocks.Count; ++i)
                if (alarmClocks[i] < curDateSeconds) alarmClocks[i] += 24 * 3600;
            alarmClocks.Sort();
            for (int i = 0; i < alarmClocks.Count; ++i)
                if (alarmClocks[i] > 24 * 3600) alarmClocks[i] -= 24 * 3600;
        }

        private void buttonClosest_Click(object sender, EventArgs e)
        {
            sortAlarms();
        }

        private void checkBoxShowAlarms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowAlarms.Checked)
            {
                showAlarms = true;
                for (int i = 0; i < alarmClocks.Count; ++i)
                    timersAndAC.Items.Insert(timers.Count * Convert.ToInt32(showTimers) + i + Convert.ToInt32(showTimers) * Convert.ToInt32(timers.Count > 0) , "Alarm clock " + (i + 1) + " is set for: " + secondsToTimeString(alarmClocks[i]));
            }
            else
            {
                showAlarms = false;
                timersAndAC.Items.Clear();
                if(showTimers && timers.Count > 0)
                    if (checkBoxShowTimers.Checked)
                    {
                        int fastestToGoOff = 0, minValue = int.MaxValue;
                        for (int i = 0; i < timers.Count; ++i)
                        {
                            if (timers[i] < minValue)
                            {
                                minValue = timers[i];
                                fastestToGoOff = i;
                            }
                        }
                        timersAndAC.Items.Add("Timer " + (fastestToGoOff + 1) + " is closest to go off\n");
                        for (int i = 0; i < timers.Count; ++i)
                            timersAndAC.Items.Add("Timer " + (i + 1) + ": " + secondsToTimeString(timers[i]));
                    }
            }
        }

        private void buttonFurthest_Click(object sender, EventArgs e)
        {
            sortAlarms();
            alarmClocks.Reverse();
        }

        private void checkBoxShowTimers_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowTimers.Checked)
            {
                showTimers = true;
                int fastestToGoOff = 0, minValue = int.MaxValue;
                for (int i = 0; i < timers.Count; ++i)
                {
                    if (timers[i] < minValue)
                    {
                        minValue = timers[i];
                        fastestToGoOff = i;
                    }
                }
                timersAndAC.Items.Insert(0, "Timer " + (fastestToGoOff + 1) + " is closest to go off\n");
                for (int i = 0; i < timers.Count; ++i)
                timersAndAC.Items.Insert(i + 1, "Timer " + (i + 1) + ": " + secondsToTimeString(timers[i]));
            }
            else
            {
                showTimers = false;
                timersAndAC.Items.Clear();
                if (checkBoxShowAlarms.Checked)
                {
                    for (int i = 0; i < alarmClocks.Count; ++i)
                        timersAndAC.Items.Add("Alarm clock " + (i + 1) + " is set for: " + secondsToTimeString(alarmClocks[i]));
                }
            }
        }
    }
}