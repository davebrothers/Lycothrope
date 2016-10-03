using System;
using System.Windows.Forms;

namespace Lycothrope.Forms
{
    public partial class Settings : Form
    {
        private readonly Tomato _tomato;
        public Settings(Tomato tomato)
        {
            _tomato = tomato;
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            _tomato.LifespanUpdated += OnLifeSpanUpdated;
            GetTomatoTimes();
        }

        private void GetTomatoTimes()
        {
            nudPomodoro.Value = _tomato.GetDefaultLifespanFor(Cultivar.Pomodoro);
            nudShortBreak.Value = _tomato.GetDefaultLifespanFor(Cultivar.ShortBreak);
            nudLongBreak.Value = _tomato.GetDefaultLifespanFor(Cultivar.LongBreak);
        }

        protected virtual void OnLifeSpanUpdated(object o, LycothropeEventArgs e)
        {
            toolStripStatusLabel.Text = e.Message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _tomato.UpdateAllCultivarLifespans((int) nudPomodoro.Value, (int) nudShortBreak.Value,
                (int) nudLongBreak.Value);
        }
    }
}
