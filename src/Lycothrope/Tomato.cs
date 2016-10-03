using System;

namespace Lycothrope
{
    public class Tomato : ITomato
    {
        public event TomatoEventHandler LifespanUpdated;
        private readonly Cultivar _cultivar;
        private readonly int _lifespan;

        public Tomato(Cultivar cultivar)
        {
            _cultivar = cultivar;
            _lifespan = LifespanFor(cultivar);
        }

        public Tomato()
            : this(Lycothrope.Cultivar.Pomodoro)
        {
        }

        public Cultivar Cultivar()
        {
            return _cultivar;
        }

        public int Lifespan()
        {
            return _lifespan;
        }

        private static int LifespanFor(Cultivar cultivar)
        {
            switch (cultivar)
            {
                case (Lycothrope.Cultivar.ShortBreak):
                    return Properties.Settings.Default.ShortBreak;
                case (Lycothrope.Cultivar.LongBreak):
                    return Properties.Settings.Default.LongBreak;
                case Lycothrope.Cultivar.Pomodoro:
                default:
                    return Properties.Settings.Default.Pomodoro;
            }
        }

        public void UpdateDefaultCultivarLifespan(Cultivar cultivar, int newLifespanInMinutes)
        {
            Properties.Settings.Default[cultivar.ToString()] = newLifespanInMinutes;
            Properties.Settings.Default.Save();
        }

        public int GetDefaultLifespanFor(Cultivar cultivar)
        {
            return (int) Properties.Settings.Default[cultivar.ToString()];
        }

        public void UpdateAllCultivarLifespans(int pomodoro, int shortBreak, int longBreak)
        {
            Properties.Settings.Default["Pomodoro"] = pomodoro;
            Properties.Settings.Default["ShortBreak"] = shortBreak;
            Properties.Settings.Default["LongBreak"] = longBreak;
            Properties.Settings.Default.Save();

            var handler = LifespanUpdated;
            handler?.Invoke(this, new LycothropeEventArgs { Message = $"Updated successfully." });
        }
    }
}

