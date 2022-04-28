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

        }

        private void butAdd_Click(object sender, EventArgs e)
        {

        }

        private void ArticleReader_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_DatabaseMng.CloseConnection();
        }
    }
}
