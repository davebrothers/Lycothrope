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

        private int LifespanFor(Cultivar cultivar)
        {
            switch (cultivar)
            {
                case (Lycothrope.Cultivar.ShortBreak):
                    return 5;
                case (Lycothrope.Cultivar.LongBreak):
                    return 15;
                default:
                    return 1; //todo: 25
            }
        }
    }
}

