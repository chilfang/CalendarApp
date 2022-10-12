using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CapstoneProjectQ1 {
    class DatabaseControl {
        public static string Path = "database.db";//@"../../../database.db";

        public static void CheckPath() {
            if (!File.Exists(Path)) {
                Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/../Local/CapstoneCalendarApp";
                Directory.CreateDirectory(Path);
                Path += @"/database.db";

                if (File.Exists(Path + "NEW")) {
                    try {
                        File.Delete(Path);
                    }
                    finally {
                        File.Move(Path + "NEW", Path);
                    }
                    return;
                }

                if (!File.Exists(Path)) {
                    File.Create(Path).Dispose();

                    using (SqliteConnection connection = new SqliteConnection("Data Source=" + Path)) {
                        connection.Open();
                        using (SqliteCommand command = connection.CreateCommand()) {
                            command.CommandText = @"
                                CREATE TABLE ""notes"" (
                                    ""date""  DATE NOT NULL,
	                                ""title"" TEXT,
	                                ""description""   TEXT,
                                    ""creationDate""    smalldatetime NOT NULL
                                );

                                CREATE TABLE ""options"" (
                                    ""option""  TEXT,
                                    ""data""  TEXT
                                );

                                INSERT INTO options (option, data) VALUES (""backgroundColor"", $backgroundColor$);
                                INSERT INTO options (option, data) VALUES (""buttonColor"", $buttonColor$);
                                INSERT INTO options (option, data) VALUES (""currentMonthColor"", $currentMonthColor$);
                                INSERT INTO options (option, data) VALUES (""otherMonthColor"", $otherMonthColor$);
                                INSERT INTO options (option, data) VALUES (""borderColor"", $borderColor$);
                                INSERT INTO options (option, data) VALUES (""noteColor"", $noteColor$);
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
                }

            }
        }
    }
}

