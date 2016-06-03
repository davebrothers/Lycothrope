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

            _scheduler.TimerExpires += TimerExpires;
        }

        private void TimerExpires(object sender, EventArgs e)
        {
            _writer.Write();
        }
    }
}

