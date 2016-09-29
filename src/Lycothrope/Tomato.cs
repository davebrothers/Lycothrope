namespace Lycothrope
{
    public class Tomato : ITomato
    {
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
                    return Properties.Settings.Default.Pomodoro;
                case (Lycothrope.Cultivar.LongBreak):
                    return Properties.Settings.Default.LongBreak;
                case Lycothrope.Cultivar.Pomodoro:
                default:
                    return Properties.Settings.Default.Pomodoro;
            }
        }
    }
}

