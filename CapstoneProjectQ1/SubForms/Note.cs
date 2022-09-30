using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CapstoneProjectQ1.SubForms {
    public partial class Note : Form {
        private string path = DatabaseControl.Path;
        private DateTime targetDate;

        public Note(DateTime targetDate) {
            InitializeComponent();

            this.targetDate = targetDate;

            LoadNote();
        }

        private void Note_FormClosing(object sender, FormClosingEventArgs e) {
            SaveNote();
        }

        public void SaveNote() {
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + path)) {
                connection.Open();

                using (SqliteCommand command = connection.CreateCommand()) {

                    command.CommandText = @"
                        SELECT date, title, description, creationDate
                        FROM notes
                        WHERE date = $date$
                    ";

                    command.Parameters.AddWithValue("$date$", targetDate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("$title$", titleTextBox.Text);
                    command.Parameters.AddWithValue("$description$", descriptionTextBox.Text);

                    bool found;
                    using (SqliteDataReader reader = command.ExecuteReader()) {
                        found = reader.Read();
                    }

                    if (found) {
                        if (IsNoteEmpty()) {
                            command.CommandText = @"
                                DELETE FROM notes
                                WHERE date = $date$;
                            ";
                        } else {
                            command.CommandText = @"
                                UPDATE notes
                                SET title = $title$, description = $description$
                                WHERE date = $date$;
                            ";
                        }
                    } else if (!IsNoteEmpty()) {
                        command.CommandText = @"
                            INSERT INTO notes (date, title, description, creationDate) VALUES ($date$, $title$, $description$, $creationDate$)
                        ";

                        command.Parameters.AddWithValue("$creationDate$", DateTime.Now.ToString("yyyy-MM-dd"));
                    }

                    command.ExecuteNonQuery();
                }

            }
        }

        public bool IsNoteEmpty() {
            return !(titleTextBox.Text != "" || descriptionTextBox.Text != "");
        }

        private void LoadNote() {
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + path)) {
                connection.Open();

                using (SqliteCommand command = connection.CreateCommand()) {

                    command.CommandText = @"
                        SELECT date, title, description, creationDate
                        FROM notes
                        WHERE date = $date$
                    ";

                    command.Parameters.AddWithValue("$date$", targetDate.ToString("yyyy-MM-dd"));

                    using (SqliteDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            titleTextBox.Text = reader.GetString(1);
                            descriptionTextBox.Text = reader.GetString(2);
                            creationDateLabel.Text = reader.GetString(3);
                        } else {
                            creationDateLabel.Text = DateTime.Today.ToString("d");
                        }

                        Text = targetDate.ToString("d");
                    }
                }
            }

        }
    }
}
