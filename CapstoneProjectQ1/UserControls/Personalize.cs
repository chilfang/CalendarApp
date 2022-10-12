using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace CapstoneProjectQ1 {
    public partial class Personalize : UserControl {
        private NavigationControl navigationControl;
        public Personalize(NavigationControl navigationControl) {
            InitializeComponent();
            this.navigationControl = navigationControl;



        }

        private void Personalize_Load(object sender, EventArgs e) {
            LoadColors();
        }

        private void LoadColors() {
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + DatabaseControl.Path)) {
                connection.Open();
                using (SqliteCommand command = connection.CreateCommand()) {
                    command.CommandText = @"
                        SELECT option, data
                        FROM options
                    ";

                    using (SqliteDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            switch (reader.GetString(0)) {
                                case "backgroundColor":
                                    navigationControl.mainForm.ChangeBackgroundColor(ToColor(reader.GetString(1)));
                                    break;
                                case "buttonColor":
                                    navigationControl.mainForm.ChangeButtonColor(ToColor(reader.GetString(1)));
                                    break;
                                case "currentMonthColor":
                                    navigationControl.Calendar.ChangeCalendarColors(activeDay: ToColor(reader.GetString(1)));
                                    break;
                                case "otherMonthColor":
                                    navigationControl.Calendar.ChangeCalendarColors(inactiveDay: ToColor(reader.GetString(1)));
                                    break;
                                case "borderColor":
                                    navigationControl.Calendar.ChangeCalendarColors(border: ToColor(reader.GetString(1)));
                                    break;
                                case "noteColor":
                                    navigationControl.Calendar.ChangeCalendarColors(note: ToColor(reader.GetString(1)));
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private Color ToColor(string color) {
            if (color.Any(char.IsDigit)) {
                string[] temp = color.Split(", ");
                return Color.FromArgb(Int32.Parse(temp[1][2..]), Int32.Parse(temp[2][2..]), Int32.Parse(temp[3][2..^1]));
            } else {
                return Color.FromName(color);
            }
        }

        private void ChangeBackgroundColorButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.mainForm.ChangeBackgroundColor(colorDialog1.Color);
                RecordOptionChange("backgroundColor", colorDialog1.Color);
            }
        }

        private void ChangeButtonColorButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.mainForm.ChangeButtonColor(colorDialog1.Color);
                RecordOptionChange("buttonColor", colorDialog1.Color);
            }
        }

        private void ChangeCurrentMonthColorButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.Calendar.ChangeCalendarColors(activeDay: colorDialog1.Color);
                RecordOptionChange("currentMonthColor", colorDialog1.Color);
            }
        }

        private void ChangeOtherMonthColorButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.Calendar.ChangeCalendarColors(inactiveDay: colorDialog1.Color);
                RecordOptionChange("otherMonthColor", colorDialog1.Color);
            }
        }

        private void ChangeBorderColor_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.Calendar.ChangeCalendarColors(border: colorDialog1.Color);
                RecordOptionChange("borderColor", colorDialog1.Color);
            }
        }

        private void ChangeNoteColorButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog().ToString() == "OK") {
                navigationControl.Calendar.ChangeCalendarColors(note: colorDialog1.Color);
                RecordOptionChange("noteColor", colorDialog1.Color);
            }
        }

        private void RecordOptionChange(string option, Color color) {
            string data;
            if (color.IsKnownColor) {
                data = color.Name;
            } else {
                data = color.ToString();
            }

            using (SqliteConnection connection = new SqliteConnection("Data Source=" + DatabaseControl.Path)) {
                connection.Open();

                using (SqliteCommand command = connection.CreateCommand()) {
                    command.CommandText = @"
                        UPDATE options
                        SET data = $data$
                        WHERE option = $option$;
                    ";

                    command.Parameters.AddWithValue("$option$", option);
                    command.Parameters.AddWithValue("$data$", data);

                    command.ExecuteNonQuery();
                }

            }
        }

        private void ResetColorsButton_Click(object sender, EventArgs e) {
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + DatabaseControl.Path)) {
                connection.Open();
                using (SqliteCommand command = connection.CreateCommand()) {
                    command.CommandText = @"
                        UPDATE options SET data = $backgroundColor$ WHERE option = ""backgroundColor"";
                        UPDATE options SET data = $buttonColor$ WHERE option = ""buttonColor"";
                        UPDATE options SET data = $currentMonthColor$ WHERE option = ""currentMonthColor"";
                        UPDATE options SET data = $otherMonthColor$ WHERE option = ""otherMonthColor"";
                        UPDATE options SET data = $borderColor$ WHERE option = ""borderColor"";
                        UPDATE options SET data = $noteColor$ WHERE option = ""noteColor"";
                    ";

                    command.Parameters.AddWithValue("$backgroundColor$", Color.FromArgb(128, 128, 255).ToString());
                    command.Parameters.AddWithValue("$buttonColor$", Color.FromArgb(192, 192, 255).ToString());
                    command.Parameters.AddWithValue("$currentMonthColor$", Color.White.Name);
                    command.Parameters.AddWithValue("$otherMonthColor$", Color.Gray.Name);
                    command.Parameters.AddWithValue("$borderColor$", Color.Black.Name);
                    command.Parameters.AddWithValue("$noteColor$", Color.Red.Name);

                    command.ExecuteNonQuery();
                }
            }

            LoadColors();
        }
    }
}
