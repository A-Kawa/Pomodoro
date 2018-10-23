using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Pomodoro : Form
    {
        static string thunderPath = "Sounds/thunder.wav";
        readonly SoundPlayer ThunderPlayer = new SoundPlayer(thunderPath);
        public static System.Timers.Timer timer2;
        private Ticker ticker;
        public string interruptions = "";
        public bool IsRunning = false;
        public int seconds = 0;
        public int minutes = 0;
        public int donePomodoros = 0;
        public Pomodoro()
        {
            InitializeComponent();
            ticker = new Ticker();
            SetTimer();
            PomodoroGrid.ColumnCount = 2;
            PomodoroGrid.Columns[0].Name = "Index";
            PomodoroGrid.Columns[1].Name = "Interruptions";
        }

        private void SetTimer()
        {
            timer2 = new System.Timers.Timer(1000);
            timer2.Elapsed += OnTimeEvent;
            timer2.AutoReset = true;
        }

        private void OnTimeEvent(Object source, ElapsedEventArgs e)
        {
            if (seconds < 59) { seconds++; } else { seconds = 0; minutes += 1; }    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IsRunning = !IsRunning;
            
            if (IsRunning) { timer2.Enabled=true; } else { timer2.Stop(); }
            ticker.StartStop();
            if (ticker.IsRunning){StartStop.Text = "Stop";}else{StartStop.Text = "Start";}
        }

        private void InterruptionOutside_Click(object sender, EventArgs e)
        {
            interruptions += "E";
        }

        private void TimerCounter_Click(object sender, EventArgs e)
        {

           
            TimerCounter.Text = minutes.ToString() + ":" + seconds.ToString();
        }

        private void OnEnd()
        {
            string[] row = new string[] { donePomodoros.ToString(), interruptions };
            PomodoroGrid.Rows.Add(row);
            interruptions = "";
            timer2.Stop();
            ticker.StartStop();
            donePomodoros++;
            PomodorosCounter.Text = donePomodoros.ToString();
            seconds = 0;
            minutes = 0;
            StartStop.Text = "Start";
            ThunderPlayer.Play();
            IsRunning = !IsRunning;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 59 && minutes == 24)
            {
                OnEnd();
            }
            TimerCounter.Text = minutes.ToString() + ":" + seconds.ToString();
        }

        private void InterruptionInside_Click(object sender, EventArgs e)
        {
            interruptions += "S";
        }
    }
}
