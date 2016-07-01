namespace Lycothrope
{
    public class Tomato : ITomato
    {
        private readonly Cultivar _cultivar;
        private readonly int _lifespan;

        public Tomato(Cultivar cultivar)
        {
            _cultivar = cultivar;
            _lifespan = GetLifespanFor(cultivar);
        }

        public Tomato()
            : this(Cultivar.Pomodoro)
        {
        }

        public Cultivar GetCultivar()
        {
            return _cultivar;
        }

        public int GetLifespan()
        {
            return _lifespan;
        }

        private int GetLifespanFor(Cultivar cultivar)
        {
            switch (cultivar)
            {
                case (Cultivar.ShortBreak):
                    return 5;
                case (Cultivar.LongBreak):
                    return 15;
                default:
                    return 1; //todo: 25
            }
        }
    }
}

