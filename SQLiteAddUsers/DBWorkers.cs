using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace SQLiteAddUsers
{
    internal class DBWorkers
    {
        private string db_name;
        private string init_db;
        public string DB_name { get { return db_name; } }
        public DBWorkers(string filename)
        {
            this.db_name = filename;
            init_db = "CREATE TABLE IF NOT EXISTS Users (id INTEGER PRIMARY KEY AUTOINCREMENT," +
                      "name VARCHAR NOT NULL," +
                      "age INTEGER NOT NULL," +
                      "hello VARCHAR);";
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source ={db_name};"))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = init_db;
                cmd.ExecuteNonQuery();
            }
        }
        public void AddData(string name, int age)
        {
            string query = $"INSERT INTO Users (name, age) VALUES ('{name}', {age});";
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
