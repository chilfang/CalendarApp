using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CapstoneProjectQ1 {
    public class NavigationControl {
        public MainForm mainForm;
        public Panel userControlsPanel;

        public List<UserControl> UserControls = new List<UserControl>();
        public Calendar Calendar;
        public Schedule Schedule;
        public Personalize Personalize;
        public Options Options;

        public NavigationControl(MainForm mainForm) {
            this.mainForm = mainForm;
        }

        public void SetupUserControls(Panel userControlsPanel) {
            this.userControlsPanel = userControlsPanel;

            UserControls.Add(Calendar);
            UserControls.Add(Schedule);
            UserControls.Add(Personalize);
            UserControls.Add(Options);

            foreach (UserControl userControl in UserControls) {
                userControl.Dock = DockStyle.Fill;
                userControlsPanel.Controls.Add(userControl);
            }
        }

        /*
        public UserControl GetUserControl(Type userControl) {
            for (int i = 0; i < userControls.Count; i++) {
                if (userControls[i].GetType() == userControl) {
                    return userControls[i];
                }
            }

            throw new MissingMemberException($"User control {userControl.Name} could not be found.");
        }
        */
    }
}
