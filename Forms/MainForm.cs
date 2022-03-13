using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using tcgy_3_bookArchive.Data;

namespace tcgy_3_bookArchive.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private readonly BookshopDbContext bookshopDbContext = new BookshopDbContext();

        private void MainForm_Load(object sender, EventArgs e)
        {
            bookshopDbContext.Database.EnsureCreated();

            ShowSimpleList();
        }

        private void ShowSimpleList()
        {
            var allContext = bookshopDbContext.Books
                .Include(b => b.Authors)
                .ThenInclude(ba => ba.Author)
                .Include(b => b.Publishers)
                .ThenInclude(bp => bp.Publisher);

            var data = allContext
                .Select(b => new
                {
                    b.ID,
                    b.Name,
                    Author = b.Authors.ToList()[0].Author.Name + " " +
                             b.Authors.ToList()[0].Author.LastName,
                    Publisher = b.Publishers.ToList()[0].Publisher.Name
                });

            dataGridView1.DataSource = data.ToList();

            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
        }


        private void b_addBook_Click(object sender, EventArgs e)
        {
            var form = new BookForm();
            form.FormClosing += new FormClosingEventHandler(this.BookFormClosing);
            form.Show();
        }

        private void b_addAuthor_Click(object sender, EventArgs e) => new AuthorForm().Show();

        private void b_addPublisher_Click(object sender, EventArgs e) => new PublisherForm().Show();

        private void BookFormClosing(object sender, FormClosingEventArgs e) => ShowSimpleList();
    }
}
