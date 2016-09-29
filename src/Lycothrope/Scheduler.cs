using System;
using System.Timers;

namespace Lycothrope
{
    public delegate void TomatoEventHandler(object o, LycothropeEventArgs e);

    public class Scheduler : IScheduler
    {
        public event TomatoEventHandler TimerExpired;
        public event TomatoEventHandler TomatoStarted;
        public event TomatoEventHandler TomatoCanceled;
        public Timer Timer { get; set; }
        private readonly Tomato _tomato;
        private int _timerElapsedCount;

        public Scheduler(Tomato tomato)
        {
            _tomato = tomato;
            InitTimer();
        }

        public Tomato GetTomato => _tomato;

        public void BeginPomodoro()
        {
            if (!TimerIsAvailable())
                throw new Exception("Timer is not available."); //todo: restart timer (?)
            Timer.Start();
            OnTomatoStarted(new LycothropeEventArgs {Message = $"Enjoy your {_tomato.Cultivar()}"});
        }

        public void StopPomodoro()
        {
            Timer.Stop();
        }

        public void OnTomatoCanceled(object s, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected virtual void OnTimerExpired(LycothropeEventArgs e)
        {
            Timer.Stop();
            var handler = TimerExpired;
            handler?.Invoke(this, e);
        }

        private void OnTomatoStarted(LycothropeEventArgs e)
        {
            var handler = TomatoStarted;

            handler?.Invoke(this, e);
        }

        private void OnTimerElapsed()
        {
            _timerElapsedCount++;

            if (_timerElapsedCount >= _tomato.Lifespan() * 60)
                OnTimerExpired(new LycothropeEventArgs {Message = "Timer expired."});
        }

        public bool TimerIsAvailable()
        {
            return !Timer.Enabled;
        }

        private void InitTimer()
        {
            Timer = new Timer(1000);
            Timer.Elapsed += (s, e) =>
            {
                OnTimerElapsed();
            };
        }

        private void Reset()
        {
            _timerElapsedCount = 0;

        }
    }
}