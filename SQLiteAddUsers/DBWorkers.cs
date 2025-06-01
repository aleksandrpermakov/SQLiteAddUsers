using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace SQLiteAddTime
{
    internal class DBWorkers
    {
        private string db_name;
        private string init_db;
        public string DB_name { get { return db_name; } }
        public DBWorkers(string filename)
        {
            this.db_name = filename;
            init_db = "CREATE TABLE IF NOT EXISTS Time (id INTEGER PRIMARY KEY AUTOINCREMENT," +
                      "name VARCHAR NOT NULL," +
                      "comment VARCHAR NOT NULL;";
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source ={db_name};"))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = init_db;
                cmd.ExecuteNonQuery();
            }
        }
        
        public void AddDataTime(string time, string comment)
        {
            string query = $"INSERT INTO Users (name, age) VALUES ('{time}', {comment});";
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source ={db_name};"))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
        }

    }
}
