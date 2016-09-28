using System;
using System.Timers;
using Moq;
using NUnit.Framework;

namespace Lycothrope.Tests
{
    [TestFixture]
    public class LycothropeTests
    {
        [Test]
        public void NewTomatoDefaultsToPomodoroCultivar()
        {
            var t = new Tomato();

            Assert.That(t.Cultivar(), Is.EqualTo(Cultivar.Pomodoro));
        }

        [Test]
        public void PomodoroLifespanDefaultsToTwentyFiveMinutes()
        {
            var t = new Tomato();

            Assert.That(t.Lifespan, Is.EqualTo(25));
        }

        [Test]
        public void ShortBreakLifespanDefaultsToFiveMinutes()
        {
            var t = new Tomato(Cultivar.ShortBreak);

            Assert.That(t.Lifespan, Is.EqualTo(5));
        }

        [Test]
        public void LongBreakLifespanDefaultsToFifteenMinutes()
        {
            var t = new Tomato(Cultivar.LongBreak);

            Assert.That(t.Lifespan, Is.EqualTo(15));
        }

        [Test]
        public void DisposingTimerMakesNotEnabled()
        {
            var timer = new Timer(1000);
            timer.Start();
            timer.Stop();
            timer.Dispose();

            Assert.That(!timer.Enabled);
        }

        [Test]
        public void WriteOnTimerExpired()
        {
            var scheduler = new Mock<IScheduler>();
            var writer = new Mock<IWriter>();
            new Implementation(scheduler.Object, writer.Object);

            scheduler.Raise(s => s.TimerExpired += null, new LycothropeEventArgs {Message = "timer expired"});
            writer.Verify(w => w.Write("timer expired"));
        }

        [Test]
        public void WriteOnTomatoStarted()
        {
            var scheduler = new Mock<IScheduler>();
            var writer = new Mock<IWriter>();
            new Implementation(scheduler.Object, writer.Object);

            scheduler.Raise(s => s.TomatoStarted += null, new LycothropeEventArgs { Message = "tomato started" });
            writer.Verify(w => w.Write("tomato started"));
        }

        [Test]
        public void SchedulerDoesNotAllowMultipleSimultaneousTomatoes()
        {
            // todo: should probably do something with this besides throw an ex.
            var scheduler = new Scheduler(new Tomato());
            var writer = new Mock<IWriter>();
            new Implementation(scheduler, writer.Object);

            scheduler.BeginPomodoro();
            
            Assert.Throws<Exception>(() => scheduler.BeginPomodoro());
        }
    }
}

