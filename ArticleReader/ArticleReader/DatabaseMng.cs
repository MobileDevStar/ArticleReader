using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMngNameSpace
{
    public class DatabaseMng
    {
        private static SQLiteConnection conn;

        public DatabaseMng()
        {
            conn = OpenConnection("Data Source=articles.sqlite");
            InitDatabase();
        }

        private SQLiteConnection OpenConnection(string name)
        {
            SQLiteConnection sqlite_conn = null;
            
            sqlite_conn = new SQLiteConnection(name);
            sqlite_conn.Open();

            return sqlite_conn;
        }

        private void InitDatabase()
        {
            SQLiteCommand cmd = null;
            string sql = "CREATE TABLE IF NOT EXISTS articles ( id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, title VARCHAR(500) NOT NULL, " +
                     "url VARCHAR(260) NOT NULL);";

            cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
        }

        public void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
