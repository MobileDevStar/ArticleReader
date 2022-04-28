using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbModelNameSpace;

namespace ArticleReader
{
    public partial class PdfViewer : Form
    {
        private ArticleModel m_article;
        public PdfViewer()
        {
            InitializeComponent();
        }

        public PdfViewer(ArticleModel article)
        {
            m_article = article;
            InitializeComponent();
        }

        private void PdfViewer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
