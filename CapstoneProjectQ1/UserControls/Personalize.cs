using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapstoneProjectQ1 {
    public partial class Personalize : UserControl {
        private NavigationControl navigationControl;
        public Personalize(NavigationControl navigationControl) {
            InitializeComponent();
            this.navigationControl = navigationControl;
        }

        private void ChangeControlPanelButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.mainForm.ChangeNavigationPanelColor(colorDialog1.Color);
            }
        }

        private void ChangeNavigationPanelButtonColorButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.mainForm.ChangeNavigationPanelButtonColor(colorDialog1.Color);
            }
        }

        private void ChangeCurrentMonthColorButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.Calendar.ChangeCalendarColors(activeDay: colorDialog1.Color);
            }
        }

        private void ChangeOtherMonthColorButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.Calendar.ChangeCalendarColors(inactiveDay: colorDialog1.Color);
            }
        }

        private void ChangeBorderColor_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.Calendar.ChangeCalendarColors(border: colorDialog1.Color);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.Calendar.ChangeCalendarColors(note: colorDialog1.Color);
            }
        }
    }
}
