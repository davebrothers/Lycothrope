using System.Timers;
using Moq;
using NUnit.Framework;

namespace Lycothrope.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void NewTomatoDefaultsToPomodoroCultivar()
        {
            var p = new Tomato();

            Assert.That(p.GetCultivar(), Is.EqualTo(Cultivar.Pomodoro));
        }

        [Test]
        public void PomodoroLifespanDefaultsToTwentyFiveMinutes()
        {
            var p = new Tomato();

            Assert.That(p.GetLifespan, Is.EqualTo(25));
        }

        [Test]
        public void ShortBreakLifespanDefaultsToFiveMinutes()
        {
            var p = new Tomato(Cultivar.ShortBreak);

            Assert.That(p.GetLifespan, Is.EqualTo(5));
        }

        [Test]
        public void LongBreakLifespanDefaultsToFifteenMinutes()
        {
            var p = new Tomato(Cultivar.LongBreak);

            Assert.That(p.GetLifespan, Is.EqualTo(15));
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
    }
}

