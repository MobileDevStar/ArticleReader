using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbMngNameSpace;
using DbModelNameSpace;

namespace ArticleReader
{
    public partial class ArticleReader : Form
    {
        private static DatabaseMng m_DatabaseMng;

        public ArticleReader()
        {
            InitializeComponent();
            m_DatabaseMng = new DatabaseMng();
        }

        private void ArticleReader_Load(object sender, EventArgs e)
        {
            ReloadArticles();
        }

        private void ReloadArticles()
        {
            listArticles.Items.Clear();
            List<ArticleModel> articles = m_DatabaseMng.GetAllArticles();

            int index = 0;
            foreach (ArticleModel article in articles)
            {
                index++;
                ListViewItem item = new ListViewItem(new string[] { index.ToString(), article.Title.ToString(), article.Url.ToString() });
                item.Tag = article;
                listArticles.Items.Add(item);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string title = textArticleTitle.Text.ToString();
            string url = textArticleUrl.Text.ToString();
            if (title == "" || url == "")
            {
                MessageBox.Show("Please input the title and url correctly.");
                return;
            }
            Console.WriteLine("Article Title: " + title);
            Console.WriteLine("Article Url: " + url);
            m_DatabaseMng.InsertArticle(title, url);

            textArticleTitle.Text = "";
            textArticleUrl.Text = "";

            ReloadArticles();
        }

        private void ArticleReader_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_DatabaseMng.CloseConnection();
        }

        private void listArticles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = listArticles.SelectedItems[0];
                ArticleModel data = (ArticleModel)selectedItem.Tag;
                Console.WriteLine(data.Url);

                /*
                var form = new PdfViewer(data);
                form.ShowDialog();
                */
                System.Diagnostics.Process.Start(data.Url);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
