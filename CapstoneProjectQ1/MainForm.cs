using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapstoneProjectQ1 {
    public partial class MainForm : Form {
        public NavigationControl navigationControl;
        public MainForm() {
            InitializeComponent();
            InitializeNavigationControl();
        }

        private void InitializeNavigationControl() {
            // TODO - change this to use the same logic as DatabaseControl
            navigationControl = new NavigationControl(this);

            navigationControl.Calendar = new Calendar(navigationControl);
            navigationControl.Schedule = new Schedule();
            navigationControl.Options = new Options(navigationControl);

            navigationControl.Personalize = new Personalize(navigationControl); //should always be created last (unknown if needed but is assumed so)

            navigationControl.SetupUserControls(userControlsPanel);
        }

        private void Form1_Load(object sender, EventArgs e) {
            navigationControl.Calendar.BringToFront(); //make sure the Calendar is the first user control seen
        }


        // color changes
        public void ChangeBackgroundColor(Color color) {
            NavigationPanel.BackColor = color;

            foreach (UserControl userControl in navigationControl.UserControls) {
                userControl.BackColor = color;
            }
        }

        public void ChangeButtonColor(Color color) {
            foreach (Control control in NavigationPanel.Controls) {
                if (control.GetType() == typeof(Button)) {
                    control.BackColor = color;
                }
            }

            foreach (UserControl userControl in navigationControl.UserControls) {
                foreach (Button button in (from Control control in userControl.Controls where control.GetType() == typeof(Button) select control).ToArray()) {
                    if (Convert.ToString(button.Tag).Contains("NoColorChange")) continue;
                    button.BackColor = color;
                }
            }
        }


        // Navigation between user controls
        private void CalendarButton_Click(object sender, EventArgs e) {
            navigationControl.Calendar.BringToFront();
        }
        private void PersonalizeButton_Click(object sender, EventArgs e) {
            navigationControl.Personalize.BringToFront();
        }
        private void ScheduleButton_Click(object sender, EventArgs e) {
            navigationControl.Schedule.BringToFront();
        }
        private void OptionsButton_Click(object sender, EventArgs e) {
            navigationControl.Options.BringToFront();
        }
    }
}
