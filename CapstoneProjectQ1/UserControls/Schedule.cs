using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CapstoneProjectQ1 {
    public partial class Schedule : UserControl {
        private string path = DatabaseControl.Path;

        public Schedule() {
            InitializeComponent();

            textBox1.BackColor = Color.White;
        }

        public new void BringToFront() {
            base.BringToFront();

            textBox1.Clear();

            using (SqliteConnection connection = new SqliteConnection("Data Source=" + path)) {
                connection.Open();

                using (SqliteCommand command = connection.CreateCommand()) {
                    command.CommandText = @"
                        SELECT date, title, description, creationDate
                        FROM notes
                        WHERE date >= $date$
                        ORDER BY date ASC;
                    ";

                    command.Parameters.AddWithValue("$date$", DateTime.Now.ToString("yyyy-MM-dd"));


                    using (SqliteDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            textBox1.AppendText($"* ({reader.GetString(0)}) {reader.GetString(1)} - {reader.GetString(2)}");
                            textBox1.AppendText(Environment.NewLine);
                        }
                    }
                }
            }
        }


    }
}
