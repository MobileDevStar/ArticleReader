using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModelNameSpace
{
    public class ArticleModel
    {
        private int id; // field

        public int Id   // property
        {
            get { return id; } // get method
            set { id = value; } // set method
        }

        private string title; // field

        public string Title // property
        {
            get { return title; }   // get method
            set { title = value; }  // set method
        }

        private string url; // field

        public string Url   // property
        {
            get { return url; } // get method
            set { url = value; } // set method
        }

        public ArticleModel(int id, string title, string url)
        {
            Id = id;
            Title = title;
            Url = url;
        }
    }
}
