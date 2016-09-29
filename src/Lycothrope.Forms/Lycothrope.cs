using System;
using System.Windows.Forms;

namespace Lycothrope.Forms
{
    public partial class Lycothrope : Form
    {
        public event TomatoEventHandler TimerReplaced;
        private Scheduler _scheduler;
        private Tomato _tomato;
        private DateTime _dateTimeTimer;

        public Lycothrope()
        {
            InitializeComponent();
        }

        private void Lycothrope_Load(object sender, EventArgs e)
        {
            ToggleStopButton();
            toolStripStatusLabel.Spring = true;
            toolStripStatusLabel.Text = @"";
            ClearTimerText();
        }
        
        private void OnTomatoStarted(object o, LycothropeEventArgs e)
        {
            toolStripStatusLabel.Text = e.Message;
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            InitScheduler();
            StartTimer();
        }

        private void btnShortBreak_Click(object sender, EventArgs e)
        {
            InitScheduler(Cultivar.ShortBreak);
            StartTimer();
        }

        private void btnLongBreak_Click(object sender, EventArgs e)
        {
            InitScheduler(Cultivar.LongBreak);
            StartTimer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }
        
        private void InitScheduler(Cultivar cultivar = Cultivar.Pomodoro)
        {
            _tomato = new Tomato(cultivar);
            _scheduler = new Scheduler(_tomato) {Timer = {SynchronizingObject = tbTimer}};

            _dateTimeTimer = new DateTime();
            _scheduler.Timer.Elapsed += (sender, args) =>
            {
                _dateTimeTimer = _dateTimeTimer.AddSeconds(1);
                tbTimer.Text = _dateTimeTimer.ToString("mm:ss");
            };

            SubscribeSchedulerEvents();
        }

        private void SubscribeSchedulerEvents()
        {
            _scheduler.TomatoStarted += OnTomatoStarted;

            _scheduler.TimerExpired += (n, p) =>
            {
                MessageBox.Show(p.Message);
            };
        }

        private void StartTimer()
        {
            ToggleControlButtons();
            ClearTimerText();
            _scheduler.BeginPomodoro();
        }

        private void StopTimer()
        {
            _scheduler.StopPomodoro();
            ToggleControlButtons();
        }

        private void ToggleControlButtons()
        {
            btnPomodoro.Enabled = !btnPomodoro.Enabled;
            btnShortBreak.Enabled = !btnShortBreak.Enabled;
            btnLongBreak.Enabled = !btnLongBreak.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
        }

        private void ToggleStopButton()
        {
            btnStop.Enabled = !btnStop.Enabled;
        }

        private void ClearTimerText()
        {
            tbTimer.Text = @"00:00";
        }
    }
}
