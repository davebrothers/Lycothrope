using System;
using System.ComponentModel;
using System.Timers;

namespace Lycothrope
{
    public delegate void TomatoEventHandler(object o, LycothropeEventArgs e);

    public class Scheduler : IScheduler
    {
        public event TomatoEventHandler TimerExpired;
        public event TomatoEventHandler TomatoStarted;
        private readonly Timer _timer;
        private readonly Tomato _tomato;
        private int _timerElapsedCount;

        public Scheduler(Tomato tomato)
        {
            _tomato = tomato;
            _timer = new Timer(1000);
            _timer.Elapsed += (s, e) =>
            {
                TimerElapsed();
            };
        }

        public Tomato GetTomato => _tomato;

        public void BeginPomodoro()
        {
            if (!TimerIsAvailable())
                throw new Exception("Timer is not available.");
            _timer.Start();
            OnTomatoStarted(new LycothropeEventArgs {Message = "begin pomodoro"});
        }

        public void OnTomatoCanceled(object s, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected virtual void OnTimerExpired(LycothropeEventArgs e)
        {
            var handler = TimerExpired;
            handler?.Invoke(this, e);
        }

        private void OnTomatoStarted(LycothropeEventArgs e)
        {
            var handler = TomatoStarted;

            handler?.Invoke(this, e);
        }

        private void TimerElapsed()
        {
            _timerElapsedCount++;
            if (_timerElapsedCount >= _tomato.GetLifespan() * 60)
                OnTimerExpired(new LycothropeEventArgs {Message = "Timer expired."});
        }

        public bool TimerIsAvailable()
        {
            return !_timer.Enabled;
        }
    }
}