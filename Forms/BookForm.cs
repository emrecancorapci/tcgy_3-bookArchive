using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using tcgy_3_bookArchive.Data;
using tcgy_3_bookArchive.Entities;
using static tcgy_3_bookArchive.Extensions.FormExtensions;

namespace tcgy_3_bookArchive
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private BookshopDbContext _context = new BookshopDbContext();

        private void b_submit_Click(object sender, EventArgs e)
        {
            var booksAuthors = new List<BooksAuthors> { new BooksAuthors {
                    Author = (Author)cb_author.SelectedItem
            }};
            var booksPublishers = new List<BooksPublishers>() { new BooksPublishers {
                    Publisher = (Publisher)cb_publisher.SelectedItem
            }};
            
            var book = new Book()
            {
                Name = tb_name.Text,
                Pages = tb_pages.Text != null ? Convert.ToInt32(tb_pages.Text) : 0,
                ISBN = tb_isbn.Text != null ?Convert.ToInt64(tb_isbn.Text): 0,
                Condition = tb_condition.Text,
                Edition = tb_edition.Text,
                Authors = booksAuthors,
                Publishers = booksPublishers,
                // Language = (Language)cb_language.SelectedItem;
            };

            var x = cb_language.SelectedItem;

            booksPublishers[0].Book = book;
            booksAuthors[0].Book = book;

            var newbook = _context.Books.Add(book);
            var result = _context.SaveChanges();

            var msg = result > 0 ? "Success!" : "Failed!";
            MessageBox.Show(msg);

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            cb_author.DataSource = _context.Authors.ToList();
            cb_author.ValueMember = "ID";
            cb_author.DisplayMember = "FullName";

            cb_publisher.DataSource = _context.Publishers.ToList();
            cb_publisher.ValueMember = "ID";
            cb_publisher.DisplayMember = "Name";

            cb_language.DataSource = _context.Languages.ToList();
            cb_language.ValueMember = "ID";
            cb_language.DisplayMember = "Name";
        }
    }
}
