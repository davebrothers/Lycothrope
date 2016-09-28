using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NUnit.Framework;
// ReSharper disable InconsistentNaming

namespace Lycothrope.Forms.Tests
{
    [TestFixture]
    public class LycothropeFormsTests
    {
        private static Lycothrope Form;

        [SetUp]
        public void SetUp()
        {
            Form = new Lycothrope();
            Form.Show();
        }

        [Test]
        public void pomodoroButtons_ShouldExist()
        {
            var buttonNames = new[] { "btnPomodoro", "btnShortBreak", "btnLongBreak" };
            List<Button> pomodoroButtons = new List<Button>(
                buttonNames.Select(b => (Button) Form.Controls.Find(b, true).SingleOrDefault()));

            Assert.That(pomodoroButtons, Is.Not.Null);
            Assert.That(pomodoroButtons.Count, Is.EqualTo(buttonNames.Length));
        }

        [Test]
        public void btnPomodoro_Click_ShouldDisableTomatoBreakTypeButtons()
        {
            var btnPomodoro = (Button)Form.Controls.Find("btnPomodoro", true).Single();
            var breakTypeButtons = new[] { "btnShortBreak", "btnLongBreak" };
            List<Button> otherButtons = breakTypeButtons.Select(b => (Button) Form.Controls.Find(b, true).Single()).ToList();

            btnPomodoro.PerformClick();

            Assert.That(otherButtons.All(b => b.Enabled), Is.False);
        }
    }
}
