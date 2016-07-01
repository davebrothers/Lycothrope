using System;

namespace Lycothrope
{
    public interface IScheduler
    {
        Tomato GetTomato { get; }
        event TomatoEventHandler TimerExpired;
        event TomatoEventHandler TomatoStarted;
        event TomatoEventHandler TomatoCanceled;
        bool TimerIsAvailable();
        void BeginPomodoro();
        void StopPomodoro();
        void OnTomatoCanceled(object s, EventArgs e);
    }
}

