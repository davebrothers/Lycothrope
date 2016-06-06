using System;

namespace Lycothrope.Tests
{
    public class Implementation
    {
        private readonly IScheduler _scheduler;
        private readonly IWriter _writer;

        public Implementation(IScheduler s, IWriter w)
        {
            _scheduler = s;
            _writer = w;

            _scheduler.TimerExpired += OnTimerExpired;
            _scheduler.TomatoStarted += OnTomatoStarted;
        }

        private void OnTomatoStarted(object o, LycothropeEventArgs e)
        {
            _writer.Write(e.Message);
        }

        private void OnTimerExpired(object sender, LycothropeEventArgs e)
        {
            _writer.Write(e.Message);
        }
    }
}

