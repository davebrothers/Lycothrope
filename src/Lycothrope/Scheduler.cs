using System;
using System.Timers;

namespace Lycothrope
{
    public class Scheduler : IScheduler
    {
        public event EventHandler TimerExpires;
        private Tomato _tomato;
        private Timer _timer;
        private int _timerElapsedCount;

        public Scheduler(Tomato tomato, IWriter writer)
        {
            _tomato = tomato;
            _timer = new Timer(1000);
            _timer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                OnTimerElapsed();
            };
        }

        public Tomato GetTomato
        {
            get
            {
                return _tomato;
            }
        }

        public void BeginPomodoro()
        {
            if (!TimerIsAvailable())
                throw new Exception("Timer is not available.");
            _timer.Start();
        }

        protected virtual void OnTimerExpires()
        {
            EventHandler handler = TimerExpires;

            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        private bool TimerIsAvailable()
        {
            return !_timer.Enabled;
        }

        private void OnTimerElapsed()
        {
            _timerElapsedCount++;
            if (_timerElapsedCount >= _tomato.GetLifespan() * 60)
                OnTimerExpires();
        }
    }
}

