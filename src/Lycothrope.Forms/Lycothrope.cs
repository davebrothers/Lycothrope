using System;
using System.Windows.Forms;

namespace Lycothrope.Forms
{
    public partial class Lycothrope : Form
    {
        private Scheduler _scheduler;

        public Lycothrope()
        {
            InitializeComponent();
        }

        private void Lycothrope_Load(object sender, EventArgs e)
        {
            _scheduler = new Scheduler(new Tomato(Cultivar.Pomodoro));

        }
    }
}
