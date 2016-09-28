using System;
using System.Windows.Forms;

namespace Lycothrope.Forms
{
    public partial class Lycothrope : Form
    {
        private Scheduler _scheduler;
        private Tomato _tomato;
        private DateTime _dateTimeTimer;

        public Lycothrope()
        {
            InitializeComponent();
        }

        private void Lycothrope_Load(object sender, EventArgs e)
        {
            InitSchedulerandTomato(Cultivar.Pomodoro);
            btnStop.Enabled = false;
            _scheduler.TimerExpired += (n, p) =>
            {
                MessageBox.Show(p.Message);
            };
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void btnShortBreak_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void btnLongBreak_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _scheduler.StopPomodoro();
            TogglePomodoroButtons();
        }

        private void InitSchedulerandTomato(Cultivar cultivar)
        {
            _tomato = new Tomato(cultivar);
            _scheduler = new Scheduler(_tomato) {Timer = {SynchronizingObject = tbTimer}};

            _dateTimeTimer = new DateTime();
            _scheduler.Timer.Elapsed += (sender, args) =>
            {
                _dateTimeTimer = _dateTimeTimer.AddSeconds(1);
                tbTimer.Text = _dateTimeTimer.ToString("mm:ss");
            };
        }

        private void StartTimer()
        {
            TogglePomodoroButtons();
            _scheduler.BeginPomodoro();
        }

        private void TogglePomodoroButtons()
        {
            btnPomodoro.Enabled = !btnPomodoro.Enabled;
            btnShortBreak.Enabled = !btnShortBreak.Enabled;
            btnLongBreak.Enabled = !btnLongBreak.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
        }
    }
}
