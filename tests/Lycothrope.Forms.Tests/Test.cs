using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NUnit.Framework;

namespace Lycothrope.Forms.Tests
{
    [TestFixture]
    public class LycothropeFormsTests
    {
        private Lycothrope _form;
        private readonly string[] _breakTypeButtons = { "btnShortBreak", "btnLongBreak" };

        [SetUp]
        public void SetUp()
        {
            _form = new Lycothrope();
        }

        [Test]
        public void pomodoroButtons_ShouldExist()
        {
            _form.Show();

            var buttonNames = new[] { "btnPomodoro", "btnShortBreak", "btnLongBreak", "btnStop" };
            List<Button> pomodoroButtons = buttonNames.Select(b => 
                (Button) _form.Controls.Find(b, true).SingleOrDefault()).ToList();

            Assert.That(pomodoroButtons, Is.Not.Null);
            Assert.That(pomodoroButtons.Count, Is.EqualTo(buttonNames.Length));

            _form.Close();
        }

        [Test]
        public void btnPomodoro_Click_ShouldDisableTomatoBreakTypeButtons()
        {
            _form.Show();

            var btnPomodoro = (Button)_form.Controls.Find("btnPomodoro", true).Single();
            List<Button> otherButtons = _breakTypeButtons.Select(b => 
                (Button) _form.Controls.Find(b, true).Single()).ToList();

            btnPomodoro.PerformClick();

            Assert.That(otherButtons.All(b => b.Enabled), Is.False);

            _form.Close();
        }

        [Test]
        public void btnStop_Click_ShouldEnableAllTomatoButtons()
        {
            _form.Show();

            var btnPomodoro = (Button)_form.Controls.Find("btnPomodoro", true).Single();
            var btnStop = (Button)_form.Controls.Find("btnStop", true).Single();
            var breakButtons = _breakTypeButtons.Select(b =>
                (Button)_form.Controls.Find(b, true).Single()).ToList();

            btnPomodoro.PerformClick();
            btnStop.PerformClick();

            Assert.That(btnStop.Enabled, Is.False);
            Assert.That(breakButtons.All(b => b.Enabled), Is.True);
            Assert.That(btnPomodoro.Enabled, Is.True);

            _form.Close();
        }

    }
}
