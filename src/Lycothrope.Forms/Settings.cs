using Lycothrope;
using System;
using System.Windows.Forms;

namespace Lycothrope.Forms
{
    public partial class Settings : Form
    {
        private Tomato _tomato;
        public Settings(Tomato tomato)
        {
            _tomato = tomato;
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tbPomodoro.Text = _tomato.
        }
    }
}
