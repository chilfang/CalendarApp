using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CapstoneProjectQ1 {
    public partial class Options : UserControl {
        private NavigationControl navigationControl;
        public Options(NavigationControl navigationControl) {
            InitializeComponent();
            this.navigationControl = navigationControl;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/../Local/CapstoneCalendarApp";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/../Local/CapstoneCalendarApp";
        }

        private void ImportCalendarButton_Click(object sender, EventArgs e) {
            if (MessageBox.Show("This will overwrite the current Calendar.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result != DialogResult.OK) { return; }

                if (openFileDialog1.FileName[(openFileDialog1.FileName.LastIndexOf('.') + 1)..] != "db") {
                    if (MessageBox.Show("This file is not guaranteed to be usable, only do this if you know what you're doing.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) {
                        return;
                    }
                }

                
                MessageBox.Show(text: "The imported calendar will be used the next time the program loads.", caption: "Understood");
                try { File.Delete(DatabaseControl.Path + "NEW"); }
                finally { File.Copy(openFileDialog1.FileName, DatabaseControl.Path + "NEW"); }
            }

        }

        private void ExportCalendarButton_Click(object sender, EventArgs e) {
            DialogResult result = saveFileDialog1.ShowDialog();

            File.Copy(DatabaseControl.Path, saveFileDialog1.FileName);

        }
    }
}
