﻿using System;

namespace Lycothrope
{
    public interface IScheduler
    {
        Tomato GetTomato { get; }
        event TomatoEventHandler TimerExpired;
        event TomatoEventHandler TomatoStarted;
        void BeginPomodoro();
        void OnTomatoCanceled(object s, EventArgs e);
    }
}

