﻿using CapstoneProjectQ1.SubForms;
using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace CapstoneProjectQ1.UserControls {
    public partial class Date : UserControl {
        private string path = DatabaseControl.Path;
        public bool active;
        private DateTime dateTime;

        public Date(DateTime dateTime) {
            InitializeComponent();
            noteDisplayButton.Visible = false;

            this.dateTime = dateTime;

            dateLabel.Text = dateTime.Day.ToString();

            // if a record is found for the date that is being displayed is found, show the note button with the title
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + path)) {
                connection.Open();
                using (SqliteCommand command = connection.CreateCommand()) {
                    command.CommandText = @"
                        SELECT title
                        FROM notes
                        WHERE date = $date$
                    ";

                    command.Parameters.AddWithValue("$date$", dateTime.ToString("yyyy-MM-dd"));

                    using (SqliteDataReader reader = command.ExecuteReader()) {
                        if (reader.Read()) {
                            noteDisplayButton.Visible = true;
                            noteDisplayButton.Text = reader.GetString(0);
                        }
                    }
                }
            }
        }

        //run CreateNote() if the date is clicked
        private void Date_Click(object sender, EventArgs e) {
            CreateNote();
        }
        private void noteDisplayButton_Click(object sender, EventArgs e) {
            CreateNote();
        }

        //Creates a note form at the mouse's current position. Sets the owner to the main form to keep the note displayed above it.
        private void CreateNote() {
            Note note = new Note(dateTime) {
                Owner = ParentForm
            };

            note.FormClosed += NoteClosed; // run NoteClosed() if the note form gets closed

            note.Show();

            note.Location = MousePosition;

            noteDisplayButton.Visible = true;
        }

        //Sets the note button's text to the relevant note's title
        private void NoteClosed(Object sender, FormClosedEventArgs e) {
            if (((Note) sender).IsNoteEmpty()) {
                noteDisplayButton.Visible = false;
            } else {
                noteDisplayButton.Text = ((Note) sender).titleTextBox.Text;
            }
        }

        // runs a Drag Drop on the note button
        private void noteDisplayButton_MouseDown(object sender, MouseEventArgs e) {
            DragDropEffects dragDropResult = DoDragDrop(dateTime, DragDropEffects.Copy | DragDropEffects.Move);

            if (dragDropResult == DragDropEffects.Copy) { // if note button is sucessfully moved
                // reset note butotn
                noteDisplayButton.Visible = false;
                noteDisplayButton.Text = "";

                // delete the record for current date
                using (SqliteConnection connection = new SqliteConnection("Data Source=" + path)) {
                    connection.Open();
                    using (SqliteCommand command = connection.CreateCommand()) {
                        command.CommandText = @"
                            DELETE FROM notes
                            WHERE date = $date$;
                        ";

                        command.Parameters.AddWithValue("$date$", dateTime.ToString("yyyy-MM-dd"));

                        command.ExecuteNonQuery();
                    }
                }
            } else { // if not sucessfully moved, open the note
                CreateNote();
            }
        }
        private void Date_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(typeof(DateTime)) && (DateTime) e.Data.GetData(typeof(DateTime)) != dateTime)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Date_DragDrop(object sender, DragEventArgs e) { // on sucessful dragdrop
            // overwrite record if there is already something for the date
            if (noteDisplayButton.Visible) {
                DialogResult confirmResults = MessageBox.Show("Do you want to overwrite this note?", "Confirm overwrite.", MessageBoxButtons.YesNo);
                if (confirmResults == DialogResult.Yes) {
                    SetNote((DateTime) e.Data.GetData(typeof(DateTime)));
                }
            } else {
                SetNote((DateTime) e.Data.GetData(typeof(DateTime)));
                noteDisplayButton.Visible = true;
            }
        }

        private void SetNote(DateTime originalNoteDate) {
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + path)) {
                connection.Open();
                
                using (SqliteCommand command = connection.CreateCommand()) {
                    // get info from original date
                    command.CommandText = @"
                        SELECT date, title, description, creationDate
                        FROM notes
                        WHERE date = $date$
                    ";

                    command.Parameters.AddWithValue("$date$", originalNoteDate.ToString("yyyy-MM-dd"));

                    string titleText;
                    string descriptionText;
                    string creationDate;

                    using (SqliteDataReader reader = command.ExecuteReader()) {
                        reader.Read();
                        titleText = reader.GetString(1);
                        descriptionText = reader.GetString(2);
                        creationDate = reader.GetString(3);
                    }

                    // set info to new date
                    noteDisplayButton.Text = titleText;

                    command.CommandText = @"
                        SELECT date, title, description, creationDate
                        FROM notes
                        WHERE date = $date$
                    ";

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("$date$", dateTime.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("$title$", titleText);
                    command.Parameters.AddWithValue("$description$", descriptionText);
                    command.Parameters.AddWithValue("$creationDate$", creationDate);

                    bool found;
                    using (SqliteDataReader reader = command.ExecuteReader()) {
                        found = reader.Read();
                    }

                    if (found) {
                        command.CommandText = @"
                            UPDATE notes
                            SET title = $title$, description = $description$, creationDate = $creationDate$
                            WHERE date = $date$;
                        ";
                    } else {
                        command.CommandText = @"
                            INSERT INTO notes (date, title, description, creationDate) VALUES ($date$, $title$, $description$, $creationDate$)
                        ";
                    }

                    command.ExecuteNonQuery();
                }

            }
        }
    }
}
