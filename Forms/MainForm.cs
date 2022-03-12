using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using tcgy_3_bookArchive.Data;
using tcgy_3_bookArchive.Entities;

namespace tcgy_3_bookArchive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BookshopDbContext bookshopDbContext = new BookshopDbContext();
            bookshopDbContext.Database.EnsureCreated();

            var authorContext = bookshopDbContext.Books
                .Include(b => b.Authors)
                .ThenInclude(ba => ba.Author)
                .Include(b => b.Publishers)
                .ThenInclude(bp => bp.Publisher);

            var data = authorContext
               .Select(b => new
               {
                   b.ID,
                   b.Name,
                   Author = b.Authors.ToList()[0].Author.Name + " " +
                            b.Authors.ToList()[0].Author.LastName,
                   Publisher = b.Publishers.ToList()[0].Publisher.Name
               });

            var list = data.ToList();
            dataGridView1.DataSource = list;
        }

        private void b_addBook_Click(object sender, EventArgs e)
        {
            var form = new BookForm();
            form.Show();
        }
    }
}
