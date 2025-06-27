using System.Data.SQLite;
using System.IO;

namespace FINAL_PROJECT
{
    public static class Database
    {
        private static string dbFile = "casino.db";
        private static string connectionString = $"Data Source={dbFile};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void EnsureDatabaseExists()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }
        }

        public static void EnsureUsersTableExists()
        {
            using (var conn = GetConnection())
            {
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS users (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        username TEXT NOT NULL UNIQUE,
                        password TEXT NOT NULL
                    );";

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
