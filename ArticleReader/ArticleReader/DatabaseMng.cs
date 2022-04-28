using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbModelNameSpace;

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

        public void InsertArticle(string title, string url)
        {
            SQLiteCommand cmd = null;
            string sql = "INSERT INTO articles (title, url) VALUES('" + title + "', '" + url + "');";

            cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
        }
        
        public List<ArticleModel> GetAllArticles()
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM articles ORDER BY title ASC; ";

            sqlite_datareader = cmd.ExecuteReader();
            List<ArticleModel> dict = new List<ArticleModel>();

            while (sqlite_datareader.Read())
            {
                dict.Add(new ArticleModel(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2)));
            }

            sqlite_datareader.Close();
            sqlite_datareader.Dispose();

            return dict;
        }
    }
}
