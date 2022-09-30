using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

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
                                ""creationDate""    smalldatetime NOT NULL)
                            ";

                            command.ExecuteNonQuery();
                        }
                    }
                }   
                
            }
        }
            
            
        }
    }

