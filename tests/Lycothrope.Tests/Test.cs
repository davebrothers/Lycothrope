using System;
using System.Timers;
using Moq;
using NUnit.Framework;

namespace Lycothrope.Tests
{
    [TestFixture]
    public class LycothropeTests
    {
        [TearDown]
        public void TearDown()
        {
            Properties.Settings.Default.Pomodoro = 25;
        }

        [Test]
        public void NewTomato_DefaultsToPomodoroCultivar()
        {
            var t = new Tomato();

            Assert.That(t.Cultivar(), Is.EqualTo(Cultivar.Pomodoro));
        }

        [Test]
        public void PomodoroLifespan_DefaultsToPomodoroSetting()
        {
            var t = new Tomato();

            Assert.That(t.Lifespan, Is.EqualTo(Properties.Settings.Default.Pomodoro));
        }

        [Test]
        public void ShortBreakLifespan_DefaultsToShortBreakSetting()
        {
            var t = new Tomato(Cultivar.ShortBreak);

            Assert.That(t.Lifespan, Is.EqualTo(Properties.Settings.Default.ShortBreak));
        }

        [Test]
        public void LongBreakLifespan_DefaultsToLongBreakSetting()
        {
            var t = new Tomato(Cultivar.LongBreak);

            Assert.That(t.Lifespan, Is.EqualTo(Properties.Settings.Default.LongBreak));
        }

        [Test]
        public void DisposingTimer_MakesNotEnabled()
        {
            var timer = new Timer(1000);
            timer.Start();
            timer.Stop();
            timer.Dispose();

            Assert.That(!timer.Enabled);
        }

        [Test]
        public void Writer_WritesOnTimerExpired()
        {
            var scheduler = new Mock<IScheduler>();
            var writer = new Mock<IWriter>();
            new Implementation(scheduler.Object, writer.Object);

            scheduler.Raise(s => s.TimerExpired += null, new LycothropeEventArgs {Message = "timer expired"});
            writer.Verify(w => w.WriteToConsole("timer expired"));
        }

        [Test]
        public void Writer_WritesOnTomatoStarted()
        {
            var scheduler = new Mock<IScheduler>();
            var writer = new Mock<IWriter>();
            new Implementation(scheduler.Object, writer.Object);

            scheduler.Raise(s => s.TomatoStarted += null, new LycothropeEventArgs { Message = "tomato started" });
            writer.Verify(w => w.WriteToConsole("tomato started"));
        }

        [Test]
        public void Scheduler_DoesNotAllowMultipleSimultaneousTomatoes()
        {
            // todo: should probably do something with this besides throw an ex.
            var scheduler = new Scheduler(new Tomato());
            var writer = new Mock<IWriter>();
            new Implementation(scheduler, writer.Object);

            scheduler.BeginPomodoro();
            
            Assert.Throws<Exception>(() => scheduler.BeginPomodoro());
        }

        [Test]
        public void SettingsUpdater_ChangesDefaultTomatoTypeValues()
        {
            var pomodoroDefault = Properties.Settings.Default.Pomodoro;
            var tomato = new Tomato(Cultivar.Pomodoro);

            tomato.UpdateDefaultCultivarLifespan(Cultivar.Pomodoro, 10);

            Assert.That(pomodoroDefault, Is.Not.EqualTo(Properties.Settings.Default.Pomodoro));
        }
    }
}

