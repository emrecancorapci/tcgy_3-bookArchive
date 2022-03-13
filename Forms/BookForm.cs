using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using tcgy_3_bookArchive.Data;
using tcgy_3_bookArchive.Entities;

namespace tcgy_3_bookArchive.Forms
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private readonly BookshopDbContext _context = new BookshopDbContext();

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

        private void b_submit_Click(object sender, EventArgs e)
        {
            var name = tb_name.Text;
            var pages = TextBoxToInt(tb_pages.Text);
            var isbn = TextBoxToInt(tb_isbn.Text);
            var language = FindLanguage();

            if (CheckValues(pages, isbn, name, language)) return;

            var booksAuthors = new List<BooksAuthors> { new BooksAuthors {
                    Author = (Author)cb_author.SelectedItem
            }};
            var booksPublishers = new List<BooksPublishers>() { new BooksPublishers {
                    Publisher = (Publisher)cb_publisher.SelectedItem
            }};


            var book = new Book()
            {
                Name = name,
                Pages = (int)pages,
                ISBN = (long)isbn,
                Condition = tb_condition.Text,
                Edition = tb_edition.Text,
                Authors = booksAuthors,
                Publishers = booksPublishers,
                Language = language
            };
            
            booksPublishers[0].Book = book;
            booksAuthors[0].Book = book;

           _context.Books.Add(book);
            var result = _context.SaveChanges();

            ShowResult(result);
            Close();
        }

        private void b_cancel_Click(object sender, EventArgs e) => Close();

        private void b_addAuthor_Click(object sender, EventArgs e)
        {
            Form form = new AuthorForm();
            form.FormClosing += new FormClosingEventHandler(this.AuthorFormClosing);
            form.Show();
        }

        private void b_addPublisher_Click(object sender, EventArgs e)
        {
            Form form = new PublisherForm();
            form.FormClosing += new FormClosingEventHandler(this.PublisherFormClosing);
            form.Show();
        }

        private void AuthorFormClosing(object sender, FormClosingEventArgs e)
        {
            cb_author.DataSource = _context.Authors.ToList();
            cb_author.ValueMember = "ID";
            cb_author.DisplayMember = "FullName";
        }

        private void PublisherFormClosing(object sender, FormClosingEventArgs e)
        {
            cb_publisher.DataSource = _context.Authors.ToList();
            cb_publisher.ValueMember = "ID";
            cb_publisher.DisplayMember = "FullName";
        }

        private static void ShowResult(int result)
        {
            var (msg1, msg2) = result > 0 ? ("Success!", "added") : ("Failed!", "cannot added");
            MessageBox.Show($"Book {msg2} to database.", $"{msg1}");
        }

        private static bool CheckValues(int? pages, int? isbn, string name, Language language)
        {
            if (pages == null)
            {
                MessageBox.Show("Enter pages as number!", "Format error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (isbn == null)
            {
                MessageBox.Show("Enter isbn as number!", "Format error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            
            if (language == null)
            {
                MessageBox.Show("Language is invalid!", "Format error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (name == "")
            {
                MessageBox.Show("Name field cannot be empty!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private static int? TextBoxToInt(string str)
        {
            if (int.TryParse(str, out var result)) return result;
            else
            {
                if (str == "") return 0;
                else return null;
            }
        }

        private Language FindLanguage()
        {
            foreach (var contextLanguage in _context.Languages)
            {
                if (contextLanguage.Name != cb_language.SelectedItem.ToString()) continue;
                return contextLanguage;
            }

            return null;
        }
    }
}
