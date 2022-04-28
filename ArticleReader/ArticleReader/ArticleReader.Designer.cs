namespace ArticleReader
{
    partial class ArticleReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textArticleTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textArticleUrl = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listArticles = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // textArticleTitle
            // 
            this.textArticleTitle.Location = new System.Drawing.Point(64, 21);
            this.textArticleTitle.Name = "textArticleTitle";
            this.textArticleTitle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textArticleTitle.Size = new System.Drawing.Size(627, 20);
            this.textArticleTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Label:";
            // 
            // textArticleUrl
            // 
            this.textArticleUrl.Location = new System.Drawing.Point(64, 51);
            this.textArticleUrl.Name = "textArticleUrl";
            this.textArticleUrl.Size = new System.Drawing.Size(627, 20);
            this.textArticleUrl.TabIndex = 3;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(722, 42);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(66, 29);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Articles";
            // 
            // listArticles
            // 
            this.listArticles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.title,
            this.url});
            this.listArticles.FullRowSelect = true;
            this.listArticles.HideSelection = false;
            this.listArticles.Location = new System.Drawing.Point(12, 108);
            this.listArticles.Name = "listArticles";
            this.listArticles.Size = new System.Drawing.Size(776, 330);
            this.listArticles.TabIndex = 6;
            this.listArticles.UseCompatibleStateImageBehavior = false;
            this.listArticles.View = System.Windows.Forms.View.Details;
            this.listArticles.DoubleClick += new System.EventHandler(this.listArticles_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "No";
            this.id.Width = 100;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 200;
            // 
            // url
            // 
            this.url.Text = "URL";
            this.url.Width = 300;
            // 
            // ArticleReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listArticles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.textArticleUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textArticleTitle);
            this.Controls.Add(this.label1);
            this.Name = "ArticleReader";
            this.Text = "ArticleReader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArticleReader_FormClosed);
            this.Load += new System.EventHandler(this.ArticleReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textArticleTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textArticleUrl;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listArticles;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader url;
    }
}

