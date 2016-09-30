namespace Lycothrope
{
    public enum Cultivar
    {
        Pomodoro, ShortBreak, LongBreak
    }

    public interface ITomato
    {
        Cultivar Cultivar();
        int Lifespan();
        void UpdateDefaultCultivarLifespan(Cultivar cultivar, int newLifespanInMinutes);
    }
}

