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
        private DataGridViewRow selectedRow;

        private readonly BookshopDbContext bookshopDbContext = new BookshopDbContext();
        
        public MainForm()
        {
            InitializeComponent();
        }

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
            dataGridView1.Columns[2].Width = 113;
            dataGridView1.Columns[3].Width = 113;
        }


        private void b_addBook_Click(object sender, EventArgs e)
        {
            var form = new BookForm(null);
            form.FormClosing += new FormClosingEventHandler(this.BookFormClosing);
            form.Show();
        }

        private void b_addAuthor_Click(object sender, EventArgs e) => new AddNewAuthorForm().Show();

        private void b_addPublisher_Click(object sender, EventArgs e) => new AddNewPublisherForm().Show();

        private void BookFormClosing(object sender, FormClosingEventArgs e) => ShowSimpleList();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dataGridView1.Rows[e.RowIndex];
        }
    }
}
