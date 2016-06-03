using System;

namespace Lycothrope
{
    public interface IScheduler
    {
        Tomato GetTomato { get; }
        event EventHandler TimerExpires;
        void BeginPomodoro();
    }
}

