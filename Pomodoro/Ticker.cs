using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Media;

namespace Pomodoro
{
    class Ticker
    {      
        public static Timer timer;
        public bool IsRunning = false;
        static readonly string tickPath = "Sounds/tick.wav";
        readonly SoundPlayer TickPlayer = new SoundPlayer(tickPath);
       
        public void StartStop()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                SetTimer();
            }
            else
            {
                IsRunning = false;
                timer.Stop();
                timer.Dispose();
            }
        }
        private void SetTimer()
        {
            timer = new Timer(1000);
            timer.Elapsed += OnTimeEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void OnTimeEvent(Object source, ElapsedEventArgs e)
        {
            TickPlayer.Play();
        }
        
    }
}
